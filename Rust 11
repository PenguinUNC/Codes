//1
fn main()
{
    for i in 1..=10
    {
        println!("{i}");
    }
    let mut j = 1;
    println!();
    while j <= 10
    {
        println!("{j}");
        j += 1;
    }
}
//2
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let N: i32 = input.trim().parse().unwrap();
    let mut sum = 0;
    for i in 1..=N
    {
        sum += i;
    }
    println!("{}", sum);
}
//3
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let num: i32 = input.trim().parse().unwrap();
    for i in 1..=10
    {
        println!("{num} * {i} = {}", i * num);
    }
}
//4
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let num: i32 = input.trim().parse().unwrap();
    for i in 1..=num
    {
        if i % 2 == 0
        {
            println!("{i}");
        }
    }
}
//5
use std::io;
fn main()
{
    let mut input = String::new();
    let secret = 58;
    loop
    {
        io::stdin().read_line(&mut input).unwrap();
        let guess: i32 = input.trim().parse().unwrap();
        input.clear();
        if guess == 0
        {
            println!("Exit");
            break;
        }
        else if guess == secret
        {
            println!("You guessed right!");
            break;
        }
        else if guess < secret
        {
            println!("More!");
        }
        else
        {
            println!("Less!");
        }
    }
}
//1.5
fn main()
{
    let mut j = 1;
    while j <= 10
    {
        println!("{j}");
        j += 1;
    }
}
//2.5
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let N: i32 = input.trim().parse().unwrap();
    let mut sum = 0;
    let mut i = 1;
    loop
    {
        sum += i;
        i += 1;
        if i > N
        {
            break;
        }
    }
    println!("{}", sum);
}
//3.5
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let num: i32 = input.trim().parse().unwrap();
    let mut i = 1;
    while i <= 10
    {
        println!("{num} * {i} = {}", i * num);
        i += 1;
    }
}
//4.5
use std::io;
fn main()
{
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let num: i32 = input.trim().parse().unwrap();
    let mut i = 2;
    while i <= num
    {
        println!("{i}");
        i += 2;
    }
}
//5.5
use std::io;
fn main()
{
    let mut input = String::new();
    let secret = 15;
    let mut attemp = 5;
    let mut used_attempts = 1;
    loop
    {
        io::stdin().read_line(&mut input).unwrap();
        let guess: i32 = input.trim().parse().unwrap();
        input.clear();
        if guess == 0
        {
            println!("Exit");
            break;
        }
        else if guess == secret
        {
            println!("You guessed right! for {used_attempts} attemps");
            break;
        }
        else if guess < secret
        {
            println!("More!");
        }
        else
        {
            println!("Less!");
        }
        if attemp == 1
        {
            println!("Game over! attemps used {used_attempts}");
            break;
        }
        else
        {
            used_attempts += 1;
            attemp -= 1;
            println!("Attempts left: {}", attemp);
        }
    }
}
