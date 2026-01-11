#include <stdio.h>
#include <stdint.h>

int main(void) {
	printf("=== 系统架构分析 ===\n");
	printf("指针大小: %zd bytes\n", sizeof(void*));
	printf("long 大小: %zd bytes\n", sizeof(long));
	printf("long double 大小: %zd bytes\n", sizeof(long double));

	// 平台检测
#if defined(__linux__)
	printf("操作系统: Linux\n");
#elif defined(__APPLE__)
	printf("操作系统: macOS\n");
#elif defined(_WIN64)
	printf("操作系统: Windows 64位\n");
#elif defined(_WIN32)
	printf("操作系统: Windows 32位\n");
#else
	printf("操作系统: 其他\n");
#endif

	// 数据模型检测
#if defined(__ILP32__) || defined(_ILP32)
	printf("数据模型: ILP32 (32位)\n");
#elif defined(__LP64__)
	printf("数据模型: LP64 (64位 Unix/Linux)\n");
#elif defined(_LLP64)
	printf("数据模型: LLP64 (64位 Windows)\n");
#endif

	return 0;
}