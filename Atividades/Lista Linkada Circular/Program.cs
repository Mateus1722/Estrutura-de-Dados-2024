using System;
using System.Collections;
using System.Collections.Generic;

public class CircularLinkedList<I> : LinkedList<I> where I : class
{
    public new IEnumerator<I> GetEnumerator()
    {
        return new CircularLinkedListEnumerator<I>(this);
    }
}

public class CircularLinkedListEnumerator<I> : IEnumerator<I> where I : class
{
    private LinkedListNode<I>? _current; // O nó atual pode ser nulo
    private LinkedList<I> _list;
    private bool _firstPass;
    private LinkedListNode<I>? _startNode; // Para detectar quando voltamos ao início

    public I Current => _current?.Value ?? throw new InvalidOperationException("A lista está vazia ou não inicializada."); 
    object IEnumerator.Current => Current;

    public CircularLinkedListEnumerator(LinkedList<I> list)
    {
        _list = list ?? throw new ArgumentNullException(nameof(list));
        _current = null;
        _firstPass = true;
        _startNode = null;
    }

    public bool MoveNext()
    {
        if (_list.First == null) // Se a lista estiver vazia, não avança
            return false;

        if (_firstPass)
        {
            _current = _list.First;
            _startNode = _current; // Guardar o primeiro nó
            _firstPass = false;
        }
        else
        {
            _current = _current?.Next ?? _list.First;
        }

        // Verificar se voltamos ao primeiro nó
        return _current != _startNode;
    }

    public void Reset()
    {
        _current = null;
        _firstPass = true;
        _startNode = null;
    }

    public void Dispose() { }
}

public static class CircularLinkedListExtensions
{
    public static LinkedListNode<I>? NextCircular<I>(this LinkedListNode<I> node) where I : class
    {
        if (node != null && node.List != null)
        {
            return node.Next ?? node.List.First; // Comportamento circular: volta ao primeiro se o fim for alcançado
        }
        return null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList<string> circularList = new CircularLinkedList<string>(); // Usando strings como exemplo
        circularList.AddLast("A");
        circularList.AddLast("B");
        circularList.AddLast("C");

        // Iterando sobre a lista circular
        Console.WriteLine("Iterando sobre a lista usando foreach:");
        foreach (var item in circularList)
        {
            Console.WriteLine(item);
        }

        // Demonstração da iteração circular usando o método de extensão
        Console.WriteLine("\nIterando circularmente sobre a lista:");
        LinkedListNode<string>? current = circularList.First;
        for (int i = 0; i < 10; i++) // Itera 10 vezes para mostrar o comportamento circular
        {
            if (current != null)
            {
                Console.WriteLine($"Atual: {current.Value}");
                current = current.NextCircular(); // Avança para o próximo ou volta ao primeiro
            }
        }
    }
}
