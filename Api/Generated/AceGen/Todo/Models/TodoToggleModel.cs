/********************************************************************************
 * generated by de.acegen
 ********************************************************************************/




namespace AceGen.Todo.Models;

public class TodoToggleModel : ITodoToggleModel {

	public string? Id { get; set; }
	public bool? Done { get; set; }
	public AceGen.Todo.Models.ITodoModel? TodoToBeToggled { get; set; }
	public DateTime? UpdatedDateTime { get; set; }

	public TodoToggleModel() {
	}

	public TodoToggleModel(
		string? id,
		bool? done,
		AceGen.Todo.Models.ITodoModel? todoToBeToggled,
		DateTime? updatedDateTime
	) {
		this.Id = id;
		this.Done = done;
		this.TodoToBeToggled = todoToBeToggled;
		this.UpdatedDateTime = updatedDateTime;
	}

}



/******* S.D.G. *******/



