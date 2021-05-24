public class User{
	public User(){}

	public User(int Id,string Name,string Email,string MobileNo)
	{

	}


	public int Id{get;set;}
	public string Name{get;set;}
	public string Email{get;set;}
	public string MobileNo{get;set;}

	public override string ToString(){
		return this.Id+","+this.Name+","+this.Email;
	}

}
