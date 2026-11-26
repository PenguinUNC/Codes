//1
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let N: i32 = input.trim().parse().unwrap();
    for i in 1..=N
    {
        if i % 3 == 0 && i % 5 == 0
        {
            println!("FizzBuzz");
        }
        else if i % 3 == 0
        {
            println!("Fizz");
        }
        else if i % 5 == 0
        {
            println!("Buzz");
        }
        else
        {
            println!("{i}");
        }
    }
//2
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let mut N: i32 = input.trim().parse().unwrap();
    let mut sum = 0;
    while N > 0
    {
        sum += N % 10;
        N = N / 10;
    }
    print!("{sum}");
}
//3
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let n: i32 = input.trim().parse().unwrap();
    let mut is_prime = true;
    if n < 2
    {
        is_prime = false;
    }
    else
    {
        for i in 2..n
        {
            if n % i == 0
            {
                is_prime = false;
                break;
            }
        }
    }
    if is_prime
    {
        println!("Is prime");
    }
    else
    {
        println!("Is not prime");
    }
}
//4
use std::io;
fn main()
{
    let mut input = String::new();
    let mut count = 0;
    loop
    {
        io::stdin().read_line(&mut input).unwrap();
        let n: i32 = input.trim().parse().unwrap();
        input.clear();
        match n
        {
            1 => println!("Hello"),
            2 =>
            {
                println!("Counter: {}", count);
                count += 1;
            },
            0 =>
            {
                println!("Exit");
                break;
            },
            _ => println!("Unknown"),
        }
    }
}
//5
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let text = input.trim();
    let mut count = 0;
    for c in text.chars()
    {
        match c
        {
            'A' | 'E' | 'I' | 'O' | 'U' | 'a' | 'e' | 'i' | 'o' | 'u' => count += 1,
            _ => {},
        }
    }
    println!("Vowel: {count}");
}
