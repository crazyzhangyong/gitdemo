public Class Order{
	public string OrderNo{get;set;}
	public string Receiver{get;set;}
	
	public Order(string orderNo,string receiver){
		this.OrderNo = orderNo;
		this.Receiver = receiver;
	}
}
