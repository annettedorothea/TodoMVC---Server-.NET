/********************************************************************************
 * generated by de.acegen
 ********************************************************************************/




namespace AceGen.Todo.Data;

public class ToggleAllData : AbstractToggleAllData, IToggleAllData {
	
	public ToggleAllData(
		bool? done, 
		List<AceGen.Todo.Models.ITodoModel>? todosToBeToggled, 
		DateTime? updatedDateTime, 
		string? categoryId, 
		string uuid
	) : base(done, todosToBeToggled, updatedDateTime, categoryId, uuid) {
	}

	public ToggleAllData( string uuid ) : base(uuid) {
	}

	override public void MigrateLegacyData(String json) {
	}

	public static IToggleAllData GenerateTestData() {
		Random random = new Random();
		int n;
		IToggleAllData testData = (IToggleAllData) new AceGen.Todo.Models.ToggleAllModel();
		testData.Done = RandomBool(random);
		List<AceGen.Todo.Models.ITodoModel> todosToBeToggledList = new List<AceGen.Todo.Models.ITodoModel>();
		n = random.Next(20) + 1;
		for ( int i = 0; i < n; i++ ) {
			todosToBeToggledList.Add(AceGen.Todo.Data.TodoData.GenerateTestData());
		}
		testData.TodosToBeToggled = todosToBeToggledList;
		testData.UpdatedDateTime = RandomBool(random) ? DateTime.Now.AddMinutes(random.Next(60)) : DateTime.Now.AddMinutes(-1*random.Next(60)) ;;
		testData.CategoryId = RandomString(random);
		return testData;
	}
	
	private static String RandomString(Random random) {
		String chars = "aaaaaaabcdeeeeeeeffffghiiiiiiijkllllllmmmmnnnnnnnooooooooopqrstttuuuuuuuvxyz";
		int length = random.Next(20) + 5;
		return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
	}
	
	private static bool RandomBool(Random random) {
		return random.Next() > (Int32.MaxValue / 2);
	}
	
	private static float RandomFloat(Random random) {
	    double mantissa = (random.NextDouble() * 2.0) - 1.0;
	    double exponent = Math.Pow(2.0, random.Next(-126, 128));
	    return (float)(mantissa * exponent);
	}
	
	
}



/******* S.D.G. *******/



