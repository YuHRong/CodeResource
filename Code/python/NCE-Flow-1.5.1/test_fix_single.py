#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
测试脚本：只处理一个文件，用于验证功能和格式保持
"""

import os
import re
import time
import getpass
import requests
import json


def parse_lrc_file(file_path: str):
    """解析 LRC 文件"""
    with open(file_path, 'r', encoding='utf-8') as f:
        lines = f.readlines()

    metadata = []
    subtitles = []
    time_pattern = re.compile(r'^\[(\d{2}:\d{2}\.\d{2})\](.+)$')

    for line in lines:
        line = line.rstrip('\n')

        if line.startswith('[') and any(tag in line for tag in ['[al:', '[ar:', '[ti:', '[by:']):
            metadata.append(line)
        elif time_pattern.match(line):
            match = time_pattern.match(line)
            timestamp = match.group(1)
            content = match.group(2)

            if '|' in content:
                parts = content.split('|', 1)
                english = parts[0]
                chinese = parts[1] if len(parts) > 1 else ''
                subtitles.append({
                    'timestamp': timestamp,
                    'english': english,
                    'chinese': chinese,
                    'has_translation': True,
                    'original_line': line
                })
            else:
                subtitles.append({
                    'timestamp': timestamp,
                    'content': content,
                    'has_translation': False,
                    'original_line': line
                })
        else:
            if line:
                metadata.append(line)
            else:
                subtitles.append({'empty': True, 'original_line': ''})

    return metadata, subtitles


def check_translation(api_key: str, subtitles: list, lesson_title: str):
    """调用 AI 检查翻译"""
    bilingual_pairs = []
    for idx, sub in enumerate(subtitles):
        if sub.get('has_translation', False):
            bilingual_pairs.append({
                'index': idx,
                'english': sub['english'],
                'chinese': sub['chinese']
            })

    if not bilingual_pairs:
        return subtitles, False

    # 构建提示
    pairs_text = ""
    for i, pair in enumerate(bilingual_pairs):
        pairs_text += f"{i}. 英文: {pair['english']}\n   中文: {pair['chinese']}\n\n"

    prompt = f"""请仔细检查以下新概念英语课文《{lesson_title}》的双语字幕翻译，纠正其中生硬、不准确或不自然的中文翻译。

**重要说明：**
1. 这是新概念英语教材，每句话都有特定的教学目的和场景
2. **翻译原则**：
   - 要参考上下文理解语境，但主要关注每句话本身的准确性
   - 不要因为上下文而改变单句的教学意图
   - 每句话都是独立的教学单元，要确保单句翻译的准确性和教学价值
3. **避免直译错误**：
   - 习语和固定表达要用地道的中文（如 "How do you do?" → "你好"，而非"你是怎么做到的"）
   - "Pardon?" → "什么？请再说一遍"，而非"原谅？"
   - "Good for you!" → "你真棒！"，而非"对你有好处"
4. **符合中国学生习惯**：
   - 翻译要自然、口语化
   - 适合初学者理解
   - 保持教学场景的真实感
5. 只纠正明显错误的翻译，准确的翻译请保持不变

**字幕内容：**
{pairs_text}

**请以JSON格式返回需要修正的翻译，格式如下：**
```json
[
  {{"index": 0, "corrected_chinese": "修正后的中文翻译", "reason": "修正理由"}},
  {{"index": 2, "corrected_chinese": "修正后的中文翻译", "reason": "修正理由"}}
]
```

如果某句翻译准确无需修改，则不要在返回结果中包含它。只返回需要修正的句子。
"""

    try:
        print(f"\n  🚀 发送 API 请求...")
        start_time = time.time()

        response = requests.post(
            "https://api.siliconflow.cn/v1/chat/completions",
            headers={
                "Authorization": f"Bearer {api_key}",
                "Content-Type": "application/json"
            },
            json={
                "model": "zai-org/GLM-4.6",
                "messages": [
                    {
                        "role": "system",
                        "content": "你是一位精通英语教学的专业翻译，擅长为中国学生提供准确、自然的新概念英语教材翻译。"
                    },
                    {
                        "role": "user",
                        "content": prompt
                    }
                ],
                "temperature": 0.3,
                "max_tokens": 4000
            },
            timeout=30
        )

        elapsed = time.time() - start_time
        print(f"  ✅ API 响应成功 (耗时 {elapsed:.2f}s)")

        if response.status_code != 200:
            print(f"❌ API 请求失败：{response.status_code}")
            print(response.text)
            return subtitles, False

        result = response.json()
        tokens_used = result.get('usage', {}).get('total_tokens', 0)
        print(f"  📊 Token 使用: {tokens_used}")

        ai_response = result['choices'][0]['message']['content']

        print("\n🤖 AI 完整响应:")
        print("="*60)
        print(ai_response)
        print("="*60)

        # 解析响应
        print("\n  🔍 解析 JSON 响应...")
        json_match = re.search(r'```json\s*(\[.*?\])\s*```', ai_response, re.DOTALL)
        if json_match:
            json_str = json_match.group(1)
            print(f"  ✓  找到 JSON 块")
        else:
            json_match = re.search(r'(\[.*?\])', ai_response, re.DOTALL)
            if json_match:
                json_str = json_match.group(1)
                print(f"  ✓  找到 JSON 数组")
            else:
                print("  ⚠️  未找到 JSON 响应")
                return subtitles, False

        corrections = json.loads(json_str)
        print(f"  ✓  解析成功，发现 {len(corrections)} 处修正")

        # 应用修正
        modified = False
        for correction in corrections:
            idx = correction['index']
            new_chinese = correction['corrected_chinese']
            reason = correction.get('reason', '无说明')

            if subtitles[idx]['chinese'] != new_chinese:
                print(f"\n📝 修正 #{idx + 1} [{subtitles[idx]['timestamp']}]:")
                print(f"   英文: {subtitles[idx]['english']}")
                print(f"   原译: {subtitles[idx]['chinese']}")
                print(f"   新译: {new_chinese}")
                print(f"   理由: {reason}")
                subtitles[idx]['chinese'] = new_chinese
                modified = True

        return subtitles, modified

    except requests.Timeout:
        print(f"❌ API 请求超时（30秒）")
        return subtitles, False
    except requests.RequestException as e:
        print(f"❌ 网络错误: {str(e)}")
        return subtitles, False
    except Exception as e:
        print(f"❌ 处理出错: {str(e)}")
        import traceback
        traceback.print_exc()
        return subtitles, False


def reconstruct_lrc(metadata: list, subtitles: list) -> str:
    """重建 LRC 文件"""
    lines = []

    for meta in metadata:
        lines.append(meta)

    for sub in subtitles:
        if sub.get('empty', False):
            lines.append('')
        elif sub.get('has_translation', False):
            line = f"[{sub['timestamp']}]{sub['english']}|{sub['chinese']}"
            lines.append(line)
        else:
            lines.append(sub['original_line'])

    return '\n'.join(lines) + '\n'


def main():
    print("="*60)
    print("  测试脚本：处理单个文件")
    print("="*60)

    # 获取 API Key
    api_key = getpass.getpass("\n请输入你的 SiliconFlow API Key: ")
    if not api_key:
        print("❌ API Key 不能为空！")
        return

    # 测试文件
    test_file = "NCE1/017&018－How do you do.lrc"

    if not os.path.exists(test_file):
        print(f"❌ 测试文件不存在: {test_file}")
        return

    print(f"\n📄 测试文件: {test_file}")
    print("="*60)

    # 解析
    print("\n1️⃣  解析文件...")
    metadata, subtitles = parse_lrc_file(test_file)
    print(f"   元数据行数: {len(metadata)}")
    print(f"   字幕行数: {len(subtitles)}")

    # 显示需要检查的双语内容
    bilingual = [s for s in subtitles if s.get('has_translation', False)]
    print(f"   双语行数: {len(bilingual)}")
    print("\n📋 双语内容预览:")
    for i, s in enumerate(bilingual[:5]):
        print(f"   {i}. [{s['timestamp']}] {s['english']} | {s['chinese']}")
    if len(bilingual) > 5:
        print(f"   ... 还有 {len(bilingual) - 5} 行")

    # 检查翻译
    print("\n2️⃣  调用 AI 检查翻译...")
    lesson_title = "How do you do?"
    corrected_subtitles, modified = check_translation(api_key, subtitles, lesson_title)

    if modified:
        # 保存修改
        print("\n3️⃣  保存修改...")

        # 备份
        backup_file = test_file + ".test_backup"
        with open(test_file, 'r', encoding='utf-8') as f:
            original_content = f.read()
        with open(backup_file, 'w', encoding='utf-8') as f:
            f.write(original_content)
        print(f"   ✓ 已备份到: {backup_file}")

        # 写入新内容
        new_content = reconstruct_lrc(metadata, corrected_subtitles)
        with open(test_file, 'w', encoding='utf-8') as f:
            f.write(new_content)
        print(f"   ✓ 已保存修改")

        # 验证格式
        print("\n4️⃣  验证格式...")
        with open(test_file, 'r', encoding='utf-8') as f:
            new_lines = f.readlines()

        print(f"   原始行数: {len(original_content.splitlines())}")
        print(f"   新文件行数: {len(new_lines)}")

        print("\n✅ 测试完成！请检查文件格式是否正确。")
        print(f"\n💡 如果格式正确，删除备份: rm \"{backup_file}\"")
        print(f"💡 如果格式错误，恢复备份: mv \"{backup_file}\" \"{test_file}\"")
    else:
        print("\n✓  翻译准确，无需修改")


if __name__ == "__main__":
    main()
