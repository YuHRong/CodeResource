import datetime

time = datetime.datetime.now(datetime.UTC)

print(time)

# now = datetime.datetime.combine

# print(help(datetime))

now = datetime.datetime.now();

print(now.strftime("%Y/%M/%D %H:%M:%S"))