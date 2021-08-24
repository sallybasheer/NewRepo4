using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Infra.models;
using Infra.Validation;

namespace LoginTest
{
    public class testing
    {
        [Fact]
        public void ValidateUsernamePasswordReturnValid()
        {
            var user = new User("sally", 300);
            Assert.True(user.Isvalid("sally",300));

         
        }
        [Fact]
        public void TheoryMwthodValidate()
        {
            var user = new User("sally", 300);
            var res = new validation().Validate(user);
            Assert.True(res.IsValid);


        }
        [Theory]
        [InlineData(null,100)]
        [InlineData("",100)]
        [InlineData("gfrdhhkhgkhhhjgjhhhhhhhll",101)]
        public void usernameTest(string username,int ErrorCode) {
            var user = new User() { username = username };
               /*RedStep
            Assert.Null(user.username);
            Assert.Empty(user.username);
            Assert.True(user.username.Length > 20);
            */
            var res = new validation().Validate(user);//GreenStep
            Assert.False(res.IsValid);
 }
        [Theory]
        /*[InlineData(null)]

        [InlineData(99)]
        [InlineData(1001)]
        */
        [InlineData(null,102)]//Refactor
        [InlineData(99, 103)]
        [InlineData(1001,104)]

        public void passwordTest(int id, int ErrorCode)
        {
            var user = new User() { id=id };
            var res = new validation().Validate(user);
            Assert.False(res.IsValid);



        }

    }
}
