//1
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let age: i32 = input.trim().parse().unwrap();
    if age < 0
    {
        print!("Invalid age");
    }
    else if age < 7
    {
        print!("Baby");
    }
    else if age < 18
    {
        print!("Teenager");
    }
    else if age < 60
    {
        print!("Adult");
    }
    else
    {
        print!("Senior");
    }
}
//2
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let grade: i32 = input.trim().parse().unwrap();
    if grade >= 90 && grade <= 100
    {
        print!("Excellent");
    }
    else if grade >= 75 && grade < 90
    {
        print!("Good");
    }
    else if grade >= 60 && grade < 75
    {
        print!("satisfactory");
    }
    else if grade >= 0 && grade < 60
    {
        print!("fail");
    }
    else
    {
        print!("Invalid score");
    }
}
//3
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let month: i32 = input.trim().parse().unwrap();
    match month {
        1 => print!("January"),
        2 => print!("February"),
        3 => print!("March"),
        4 => print!("April"),
        5 => print!("May"),
        6 => print!("June"),
        7 => print!("July"),
        8 => print!("August"),
        9 => print!("September"),
        10 => print!("October"),
        11 => print!("November"),
        12 => print!("December"),
        _ => print!("Invalid month"),
    }
}
// 4
use std::io;
fn main()
{
    let mut input = String::new();
    // io::stdin().read_line(&mut input).unwrap();
    // let mut a: f64 = input.trim().parse().unwrap();
    // input.clear();
    // io::stdin().read_line(&mut input).unwrap();
    // let mut b: f64 = input.trim().parse().unwrap();
    // input.clear();
    // io::stdin().read_line(&mut input).unwrap();
    // let mut r: f64 = input.trim().parse().unwrap();
    // input.clear();
    io::stdin().read_line(&mut input).unwrap();
    let figure: i32 = input.trim().parse().unwrap();
    match figure
    {
        1 =>
        {
            input.clear();
            io::stdin().read_line(&mut input).unwrap();
            let mut a: f64 = input.trim().parse().unwrap();
            if a <= 0.0
            {
                println!("invalid input");
                return;
            }
            println!("Area of square: {}", a * a);
        }
        2 =>
        {
            input.clear();
            io::stdin().read_line(&mut input).unwrap();
            let a: f64 = input.trim().parse().unwrap();

            if a <= 0.0
            {
                println!("invalid input");
                return;
            }

            input.clear();
            io::stdin().read_line(&mut input).unwrap();
            let b: f64 = input.trim().parse().unwrap();

            if b <= 0.0
            {
                println!("invalid input");
                return;
            }

            println!("Area of rectangle: {}", a * b);
        }
        3 =>
        {
            input.clear();
            io::stdin().read_line(&mut input).unwrap();
            let mut r: f64 = input.trim().parse().unwrap();
            if r <= 0.0
            {
                println!("invalid input");
                return;
            }
            println!("Area of circle: {}", r * r * 3.14159);
        }
        _ =>
        {
            println!("invalid figure");
        }
    }
}
//5
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let mut a: f64 = input.trim().parse().unwrap();
    input.clear();
    io::stdin().read_line(&mut input).unwrap();
    let mut b: f64 = input.trim().parse().unwrap();
    input.clear();
    io::stdin().read_line(&mut input).unwrap();
    let mut c: f64 = input.trim().parse().unwrap();
    if a <= 0.0 || b <= 0.0 || c <= 0.0
    {
        println!("Invalid triangle");
    }
    else if a + b <= c || a + c <= b || b + c <= a
    {
        println!("Invalid triangle");
    }
    else if a == b && b == c
    {
        println!("Equilateral triangle");
    }
    else if a == b || b == c || a == c
    {
        println!("Isosceles triangle");
    }
    else
    {
        println!("Scalene triangle");
    }
}
