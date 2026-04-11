// 定义一个复制按钮
class CopyButton {
  constructor(text) {
    this.text = text;
  }

  copy() {
    return navigator.clipboard.writeText(this.text);
  }
}

// 定义一个 MarkDown 复制按钮类，继承自 CopyButton
class MarkDownCopyButton extends CopyButton {
  constructor(text) {
    super(text);
  }

  copy() {
    return super.copy();
  }

  formatForMarkDown(text) {
    return `\`\`\`\n${text}\n\`\`\``;
  }
}

// 绑定 Markdown 渲染后的代码块复制按钮
function bindMarkdownCopyButtons({ selector = 'pre code', buttonText = '复制', copiedText = '已复制', resetDelay = 1200 } = {}) {
  document.querySelectorAll(selector).forEach(codeBlock => {
    const pre = codeBlock.closest('pre');
    if (!pre || pre.querySelector('.copy-code-button')) return;

    const button = document.createElement('button');
    button.type = 'button';
    button.className = 'copy-code-button';
    button.textContent = buttonText;
    button.style.cssText = 'position:absolute; right:8px; top:8px; padding:4px 8px; font-size:12px; cursor:pointer;';

    const currentPosition = getComputedStyle(pre).position;
    if (currentPosition === 'static') {
      pre.style.position = 'relative';
    }
    pre.appendChild(button);

    button.addEventListener('click', async () => {
      const text = codeBlock.innerText;
      const copyBtn = new MarkDownCopyButton(text);
      try {
        await copyBtn.copy();
        const originalText = button.textContent;
        button.textContent = copiedText;
        setTimeout(() => {
          button.textContent = originalText;
        }, resetDelay);
      } catch (err) {
        console.error('复制失败：', err);
      }
    });
  });
}

if (typeof document !== 'undefined') {
  document.addEventListener('DOMContentLoaded', () => bindMarkdownCopyButtons());
}
