namespace AceGen
{
    public interface IAceDao {
        void addCommandToTimeLine(string commandName, IDataContainer data);
    }
    public class AceDao : IAceDao
    {
        public void addCommandToTimeLine(string commandName, IDataContainer data) {

        }
    }
}