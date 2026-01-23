using System;
using System.Net.Http;
using System.Windows.Forms;
using zdsr;

// NewFeatureForm.cs
public partial class NewFeatureForm : Form
{
 private readonly ZdApiService _apiService;

 public NewFeatureForm(ZdApiService apiService)
 {
  InitializeComponent();
  _apiService = apiService;
 }

 // 新功能使用新的API服务
 private async void btnLoadData_Click(object sender, EventArgs e)
 {
  var result = await _apiService.GetIndexAsync();
  // 处理结果...
 }
}