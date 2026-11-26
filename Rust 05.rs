use std::io::{self, Write};
fn main()
{
    //1
    print!("your color: ");
    io::stdout().flush().unwrap();
    let mut name = String::new();
    io::stdin().read_line(&mut name).unwrap();
    let name = name.trim();
    println!("your color is {}", name);

    //2
    let mut input = String::new();
    print!("Enter length: ");
    io::stdout().flush().unwrap();
    io::stdin().read_line(&mut input).unwrap();
    let name = input.trim();
    let a: f64 = input.trim().parse().unwrap();
    let mut input = String::new();
    print!("Enter width: ");
    io::stdout().flush().unwrap();
    io::stdin().read_line(&mut input).unwrap();
    let b: f64 = input.trim().parse().unwrap();
    println!("Area: {}", a * b);

    //3
    let mut input = String::new();
    print!("your num 1: ");
    io::stdout().flush().unwrap();
    io::stdin().read_line(&mut input).unwrap();
    let a: f64 = input.trim().parse().unwrap();
    let mut input = String::new(); 
    print!("your num 2: ");
    io::stdout().flush().unwrap();
    io::stdin().read_line(&mut input).unwrap();
    let b: f64 = input.trim().parse().unwrap();
    let mut input = String::new();
    print!("your num 3: ");
    io::stdout().flush().unwrap();
    io::stdin().read_line(&mut input).unwrap();
    let c: f64 = input.trim().parse().unwrap();
    let sum = a + b + c;
    let average = sum/3.0;
    print!("{}", average);
}
