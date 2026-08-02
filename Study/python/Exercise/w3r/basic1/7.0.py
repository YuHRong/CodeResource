import os
import glob

# work_dir = 'E:/音乐'

# 获取当前目录下的所有文件
# files = [os.path.join(work_dir, file) for file in os.listdir(work_dir)]

# 使用循环便利文件列表，输出文件名
# for file in files:
    # print(file)

    # 获取当前目录
directory = os.getcwd()

# 获取所有文件
files = glob.glob(directory + '/*')

# 输出所有文件名
for file in files:
    # fiName = os.path.basename(file)
    print(file)