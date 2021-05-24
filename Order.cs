//这是一个订单实体类
public Class Order{
	public string OrderNo{get;set;}
	public string Receiver{get;set;}
	public string MobileNo{get;set;}
	public decimal TotalAmount{get;set;}
	

	public Order(string orderNo,string receiver){
		this.OrderNo = orderNo;
		this.Receiver = receiver;
	}
}
