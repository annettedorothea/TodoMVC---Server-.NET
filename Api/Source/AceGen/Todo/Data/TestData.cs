/********************************************************************************
 * generated by de.acegen
 ********************************************************************************/




namespace AceGen.Todo.Data;

public class TestData : AbstractTestData, ITestData {
	
	public TestData(
		float? testfloat, 
		int? integerTest, 
		long? longTEst, 
		float? floatTest, 
		AceGen.FormData? formData, 
		string uuid
	) : base(testfloat, integerTest, longTEst, floatTest, formData, uuid) {
	}

	public TestData( string uuid ) : base(uuid) {
	}

	override public void MigrateLegacyData(String json) {
	}

	public static ITestData GenerateTestData() {
		Random random = new Random();
		ITestData testData = (ITestData) new AceGen.Todo.Models.TestModel();
		testData.Testfloat = RandomFloat(random);
		testData.IntegerTest = random.Next(50);
		testData.LongTEst = random.Next(200000);
		testData.FloatTest = RandomFloat(random);
		testData.FormData = null;
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



