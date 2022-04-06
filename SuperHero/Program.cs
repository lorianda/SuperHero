public class Hero
{
	string name;
	string surname;
	string nickname;
	int heroID;
	string herotype; //Hero or Villain
	int deedTime;

	public Hero()
	{ }

	public Hero(string name,
				string surname,
				string nickname,
				int heroID,
				string herotype,
				int deedTime)
	{
		this.name = name;
		this.surname = surname;
		this.nickname = nickname;
		this.heroID = heroID;
		this.herotype = herotype;
		this.deedTime = deedTime;
	}

	public string getName()
	{
		return this.name;
	}

	public void setName(string name)
	{
		this.name = name;
	}

	public string getSurname()
	{
		return this.surname;
	}

	public void setSurname(string surname)
	{
		this.surname = surname;
	}

	public string getNickname()
	{
		return this.nickname;
	}

	public void setNickname(string nickname)
	{
		this.nickname = nickname;
	}

	public string getHeroType()
	{
		return this.herotype;
	}

	public void setHeroType(string herotype)
	{
		this.herotype = herotype;
	}

	public int getHeroID()
	{
		return this.heroID;
	}

	public void setHeroID(int id)
	{
		this.heroID = id;
	}

	public int getdeedTime()
	{
		return this.deedTime;
	}

	public void setdeedTime(int deed)
	{
		this.deedTime = deed;
	}

	public void PrintInfo()
	{
		Console.WriteLine("Hero Info:");
		Console.WriteLine("Name: " + name + "\n" +
						  "Surname: " + surname + "\n"
						  + "Nickname: " + nickname + "\n"
						 + "HeroID: " + heroID + "\n"
						  + "Herotype: " + herotype + "\n"
						  + "DeedTime: " + deedTime + "\n");
	}

	public int calculatedLevel()
	{
		int Level = 0;

		if (deedTime <= 20)
			Level = 1;
		else
			if ((deedTime > 20) && (deedTime <= 40))
			Level = 2;
		else if (deedTime > 40)
			Level = 3;

		return Level;
	}

	public static void Main()

	{
		int levelValue = 0;
		int levelOne = 0;
		int levelMoreOne = 0;
		bool isJohn = false;
		int id = 0;
		int deed = 0;

		Console.WriteLine("Add a Hero...");

		Hero h1 = new Hero("Lorianda", "Jatniece", "Lori", 1, "Hero", 20);
		Hero h2 = new Hero("Peter", "Clark", "Superman", 2, "Hero", 100);
		Hero h3 = new Hero("Wonder", "Woman", "Wonderwoman", 3, "Villain", 30);

		Console.WriteLine("Enter your name: ");
		string nameString = Console.ReadLine();

		Console.WriteLine("Enter your surname: ");
		string surnameString = Console.ReadLine();

		Console.WriteLine("Enter your nickname: ");
		string nicknameString = Console.ReadLine();

		Console.WriteLine("Enter your heroID: ");
		string heroIDString = Console.ReadLine();
		bool herIDParsed = int.TryParse(heroIDString, out id);

		Console.WriteLine("Enter your hero type: Hero or Villain");
		string herotypeString = Console.ReadLine();

		Console.WriteLine("Enter your Deed Time: ");
		string deedTimeString = Console.ReadLine();
		bool deedParsed = int.TryParse(deedTimeString, out deed);

		Hero h4 = new Hero(nameString, surnameString, nicknameString, id, herotypeString, deed);

		Console.WriteLine("Hero " + h4.getName() + " Added Successfully\n");

		h1.PrintInfo();
		h2.PrintInfo();
		h3.PrintInfo();
		h4.PrintInfo();

		Hero[] Metropole = new Hero[4];
		Metropole[0] = h1;
		Metropole[1] = h2;
		Metropole[2] = h3;
		Metropole[3] = h4;

		for (int i = 0; i < Metropole.Length; i++)
		{
			levelValue = Metropole[i].calculatedLevel();

			if (levelValue == 1)
				levelOne++;
			else if (levelValue > 1)
				levelMoreOne++;

			if (Metropole[i].getName().Equals("John"))
				isJohn = true;

		}
		Console.WriteLine("There are " + levelOne + " heroes with level 1");
		Console.WriteLine("There are " + levelMoreOne + " heroes with the level which is larger than 1");

		if (isJohn)
			Console.WriteLine("There are heroes with name John");
		else
			Console.WriteLine("There are no heroes with name John");
	}
}
