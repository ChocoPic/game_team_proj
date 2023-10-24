using System;

public class Sculpture
{
	private int id;
	private int total_score;
	private int is_done;
	private string name;
	private string material;
	
	//생성
	public Sculpture(int id, int score, string name, string material)
	{
		this.id = id;
		this.total_score = score;
		this.name = name;
		this.material = material;
		this.is_done = 0;
	}
	
	//조각상 번호
	public int ID
	{
		get { return id; }
	}
	//완성까지 필요한 점수
	public int TotalScore
	{
		get { return total_score; }
	}
	
	//조각상 이름
	public string Name
	{
		get { return name; }
	}
	
	//조각상 재료
	public string Material
	{
		get {return material; }
	}
	
	//완성했는지 (0:미완성, 1:New_완성직후, 2:New없어짐_완성)
	public int isDone
	{
		get { return is_done; }
		set { is_done = value; }
	}
}
