using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace KafkaWithDotNetCore
{
    public class KafkaProduser : IKafkaProduser
    {
        private readonly ILogger<KafkaProduser> _logger;
        public KafkaProduser(ILogger<KafkaProduser> logger)
        {
            _logger = logger;
        }
        public void Produce()
        {
            throw new NotImplementedException();
        }

        public Task ProduceAsync()
        {
            throw new NotImplementedException();
        }
    }
}
