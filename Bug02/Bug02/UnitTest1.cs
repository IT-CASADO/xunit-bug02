namespace Bug02
{
    public class UnitTest1 : IAsyncLifetime
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        public async ValueTask InitializeAsync()
        {
            await this.InitializeAsync();
        }

        public async ValueTask DisposeAsync()
        {
            // TODO release managed resources here
        }
    }
}
