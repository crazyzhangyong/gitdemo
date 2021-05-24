public Class Order{
	public string OrderNo{get;set;}
	public string Receiver{get;set;}
	public string MobileNo{get;set;}

	public Order(string OrderNo,string Receiver){
		this.OrderNo = OrderNo;
		this.Receiver = Receiver;
	}
}
