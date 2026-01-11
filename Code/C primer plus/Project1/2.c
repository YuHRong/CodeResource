
#include <stdio.h>
#include <windows.h>

int main(void) {
	SYSTEM_INFO sysInfo;
	GetSystemInfo(&sysInfo);

	printf("=== 简单硬件信息 ===\n");
	printf("处理器架构: ");
	switch (sysInfo.wProcessorArchitecture) {
	case PROCESSOR_ARCHITECTURE_AMD64: printf("64位 (x64)\n"); break;
	case PROCESSOR_ARCHITECTURE_INTEL: printf("32位 (x86)\n"); break;
	default: printf("未知\n");
	}
	printf("处理器核心数: %d\n", sysInfo.dwNumberOfProcessors);
	printf("页面大小: %d bytes\n", sysInfo.dwPageSize);

	MEMORYSTATUSEX memStatus;
	memStatus.dwLength = sizeof(memStatus);
	GlobalMemoryStatusEx(&memStatus);
	printf("物理内存: %.1f GB\n", (double)memStatus.ullTotalPhys / (1024 * 1024 * 1024));

	printf("按任意键退出...");
	getchar();
	return 0;
}