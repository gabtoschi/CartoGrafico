/* Represents a question in a pack. */
[System.Serializable]
public class Question {
	public int id;
	public string question;
	public string[] answers;
	public int correct;
	public string fact;
    public string url;
}

/* Represents a pack with some questions. */
[System.Serializable]
public class QuestionPack {
	public string name;
	public int capacity;
	public Question[] questions;
}

