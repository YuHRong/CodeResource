/* namespace 在代码中应用接口;

public class VIPCustomerer
{
 public int ComerId { get; set; }    //     public int CustomerId { get; set; } // Implementing property from interface从接口实现属性

  void ICustomer.ApplyLoyaltyDiscount()
 {
  // 覆盖 VIP 的默认实现
  
 }
}
 */