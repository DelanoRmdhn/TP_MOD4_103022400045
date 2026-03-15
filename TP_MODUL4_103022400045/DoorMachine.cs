using System;

public class DoorMachine
{
    enum State
    {
        Terkunci,
        Terbuka
    }

    private State state;

    public DoorMachine()
    {
        state = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        if (state == State.Terkunci)
        {
            state = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
    }

    public void KunciPintu()
    {
        if (state == State.Terbuka)
        {
            state = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }
}
