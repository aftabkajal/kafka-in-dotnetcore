using System.Threading.Tasks;

namespace KafkaWithDotNetCore
{
    public interface IKafkaProduser
    {
        void Produce();
        Task ProduceAsync();
    }
}
