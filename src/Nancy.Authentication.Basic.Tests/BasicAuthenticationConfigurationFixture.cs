using System;
using FakeItEasy;
using Nancy.Tests;
using Xunit;

namespace Nancy.Authentication.Basic.Tests
{
	public class BasicAuthenticationConfigurationFixture
	{
		[Fact]
		public void Should_throw_with_null_user_validator()
		{
			// this will create a new commit?
			var result = Record.Exception(() => new BasicAuthenticationConfiguration(null, "realm"));

			result.ShouldBeOfType(typeof(ArgumentNullException));
		}

		[Fact]
		public void Should_throw_with_null_realm()
		{
			var result = Record.Exception(() => new BasicAuthenticationConfiguration(A.Fake<IUserValidator>(), null));

			result.ShouldBeOfType(typeof(ArgumentException));
		}


	}
}
