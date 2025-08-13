using System;

public class AnimalNaoEncontradoException : Exception
{
    public AnimalNaoEncontradoException(string message) : base(message) { }
}