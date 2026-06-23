
namespace 使用接口设计弹性代码;

public class Box : IEnglishDimensions, IMetricDimensions
{
 float IEnglishDimensions.Length()
 {
  return 30.0f;
 }

 float IEnglishDimensions.Width()
 {
  return 20.0f;
 }

 float IMetricDimensions.Length()
 {
  return 76.2f;
 }

 float IMetricDimensions.Width()
 {
  return 50.8f;
 }
}
