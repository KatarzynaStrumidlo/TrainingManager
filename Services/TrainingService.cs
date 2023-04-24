using TrainingManager.Domains.Tables;
using TrainingManager.Models;

namespace TrainingManager.RestService.Services
{
    public interface ITrainingService
    {
        List<Training> GetTrainings();
    }
    public class TrainingService : ITrainingService
    {
        public List<Training> GetTrainings()
        {
            throw new NotImplementedException();
        }
    }
}
