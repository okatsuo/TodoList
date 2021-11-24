using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    static class User
    {
    private static string id;
    private static string email;
    public static string Email
    {
        get => email;
        set => email = value;
    }

    public static string Id
    {
        get => id;
        set => id = value;
    }
}
}
