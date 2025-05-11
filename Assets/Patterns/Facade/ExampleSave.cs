namespace Patterns.Facade
{
    public class ExampleSave
    {
        private SaveSystemFacade _saveSystemFacade;
    
        void Start()
        {
            _saveSystemFacade.SaveGame();
            
            _saveSystemFacade.LoadGame();
        }
    }
}