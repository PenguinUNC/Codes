//1
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let num: i32 = input.trim().parse().unwrap();
    if num > 0
    {
        print!("Positive");
    }
    else if num < 0
    {
        print!("Negative");
    }
    else
    {
        print!("Zero");
    }
}
//2
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let a: i32 = input.trim().parse().unwrap();
    input.clear();
    io::stdin().read_line(&mut input).unwrap();
    let b: i32 = input.trim().parse().unwrap();
    input.clear();
    io::stdin().read_line(&mut input).unwrap();
    let c: i32 = input.trim().parse().unwrap();
    if a >= b && a >= c
    {
        print!("{a}");
    }
    else if b >= a && b >= c
    {
        print!("{b}");
    }
    else
    {
        print!("{c}");
    }
}
//3
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let dayweek: i32 = input.trim().parse().unwrap();
    match dayweek
    {
        1 => print!("Monday"),
        2 => print!("Tuesday "),
        3 => print!("Wednesday"),
        4 => print!("Thursday"),
        5 => print!("Friday"),
        6 => print!("Saturday"),
        7 => print!("Sunday"),
        _ => print!("Error"),
    }
}
//4
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let a: f64 = input.trim().parse().unwrap();
    input.clear();
    io::stdin().read_line(&mut input).unwrap();
    let op = input.trim().to_string();
    input.clear();
    io::stdin().read_line(&mut input).unwrap();
    let b: f64 = input.trim().parse().unwrap();
    match op.as_str()
    {
        "+" => print!("{}", a + b),
        "-" => print!("{}", a - b),
        "*" => print!("{}", a * b),
        "/" =>
        {
            if b == 0.0
            {
                print!("error!");
            }
            else
            {
                print!("{}", a / b);
            }
        }
        _ => print!("Unknown operation"),
    }
}
//5
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let year: i32 = input.trim().parse().unwrap();
    if (year % 4 == 0 && year % 100 != 0) || year % 400 == 0
    {
        print!("leap");
    }
    else
    {
        print!("Non leap");
    }
}
