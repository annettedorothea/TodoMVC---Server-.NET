/********************************************************************************
 * generated by de.acegen
 ********************************************************************************/




namespace AceGen.Todo.Data;

public class TodoListData : AbstractTodoListData, ITodoListData {
	
	public TodoListData(
		List<AceGen.Todo.Models.ITodoModel>? todoList, 
		string? categoryId, 
		string uuid
	) : base(todoList, categoryId, uuid) {
	}

	public TodoListData( string uuid ) : base(uuid) {
	}

	override public void MigrateLegacyData(String json) {
	}

	public static ITodoListData GenerateTestData() {
		Random random = new Random();
		int n;
		ITodoListData testData = (ITodoListData) new AceGen.Todo.Models.TodoListModel();
		List<AceGen.Todo.Models.ITodoModel> todoListList = new List<AceGen.Todo.Models.ITodoModel>();
		n = random.Next(20) + 1;
		for ( int i = 0; i < n; i++ ) {
			todoListList.Add(AceGen.Todo.Data.TodoData.GenerateTestData());
		}
		testData.TodoList = todoListList;
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



