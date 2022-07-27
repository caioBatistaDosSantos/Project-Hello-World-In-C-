using ola_mundo;
using Xunit;
using FluentAssertions;
using System.IO;
using System;

namespace ola_mundo.Test;

public class OlaMundoTest
{
    [Theory(DisplayName = "Deve exibir Olá, Mundo!")]
    [InlineData("Olá, Mundo!")]
    public void TestOlaMundo(string Expected)
    {        
        using (var NewOutput = new StringWriter())
        {
            Console.SetOut(NewOutput);

            var expect = Message.PrintMsg();

            string result = NewOutput.ToString().Trim();

            result.Should().Be(Expected);

            expect.Should().Be(Expected); 
        }
    }
}