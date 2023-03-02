

using BugReport.Repository.user;

namespace BugReport.UnitTest
{
    public class RepositoryTest
    {
        IUserRepository repository = new EFCoreUserRepository();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateUserCheck()
        {
            // GUID로 테스트용 계정 생성
            Guid guid = Guid.NewGuid();
            var randomId = guid.ToString().Replace("-", "").Substring(0, 20);

            repository.CreateUser(randomId,"test","test");
            bool authenticateResult = repository.AuthenticateUser(randomId, "test");
            Assert.That(authenticateResult, Is.EqualTo(true));
            var user = repository.GetUser(randomId);
            Assert.That(randomId, Is.EqualTo(user.UserId));
        }
    }
}