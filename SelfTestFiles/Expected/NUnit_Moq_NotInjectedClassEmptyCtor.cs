using Moq;
using NUnit.Framework;
using UnitBoilerplate.Sandbox.Classes.Cases;

namespace UnitTestBoilerplate.SelfTest.Cases
{
	[TestFixture]
	public class NotInjectedClassEmptyCtorTests
	{
		private MockRepository mockRepository;



		[SetUp]
		public void SetUp()
		{
			this.mockRepository = new MockRepository(MockBehavior.Strict);


		}

		[TearDown]
		public void TearDown()
		{
			this.mockRepository.VerifyAll();
		}

		[Test]
		public void TestMethod1()
		{
			// Arrange


			// Act
			NotInjectedClassEmptyCtor notInjectedClassEmptyCtor = this.CreateNotInjectedClassEmptyCtor();


			// Assert

		}

		private NotInjectedClassEmptyCtor CreateNotInjectedClassEmptyCtor()
		{
			return new NotInjectedClassEmptyCtor();
		}
	}
}
