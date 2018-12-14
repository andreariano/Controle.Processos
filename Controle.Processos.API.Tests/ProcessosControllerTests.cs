namespace Controle.Processos.API.Tests
{
    public class ProcessosControllerTests
    {
//        private ProcessosController _processosController;
//        private Mock<IQueryDispatcher> _queryDispatcher;
//        private Mock<IListProcessoCommand> _listProcessoQuery;
//        private IList<Processo> _todosOsProcessos;
//
//        [SetUp]
//        public void Setup()
//        {
//            _todosOsProcessos = new List<Processo>
//            {
//                new Processo { NumeroProcesso = 1 },
//                new Processo { NumeroProcesso = 2 },
//                new Processo { NumeroProcesso = 3 }
//            };
//            _listProcessoQuery = new Mock<IListProcessoCommand>();
//            _queryDispatcher = new Mock<IQueryDispatcher>();
//            _queryDispatcher.Setup(x => x.SendQuery(_listProcessoQuery.Object))
//                .Returns(Task.FromResult<IList<Processo>>(_todosOsProcessos));
//            _processosController = new ProcessosController(_listProcessoQuery.Object, _queryDispatcher.Object);
//        }
//
//        [Test]
//        public void ListaTodosOsProcessos()
//        {
//            var processosResult = _processosController.GetAll().Result;
//
//            Assert.That(processosResult.Result, Is.InstanceOf<OkObjectResult>());
//            Assert.That(((OkObjectResult)processosResult.Result).Value, Is.EqualTo(_todosOsProcessos));            
//        }
    }
}