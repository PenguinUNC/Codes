// 1
fn main()
{
    let massiv = [10, 15, 20, 25, 30];
    println!("Foreach: ");
    for x in massiv
    {
        println!("{x}");
    }
    println!("Index: ");
    for i in 0..massiv.len()
    {
        println!("{}", massiv[i]);
    }
}
// 2
fn main()
{
    let massiv = [10, 20, 30, 40, 50];
    let mut sum = 0;
    for i in massiv
    {
        sum += i;
    }
    let average = sum as f64 / massiv.len() as f64;
    print!("Sum: {sum}, average: {average}");
}
// 3
fn main()
{
    let massiv = [10, 20, 30, 40, 50];
    let mut max = massiv[0];
    let mut min = massiv[0];
    for i in massiv
    {
        if i > max
        {
            max = i;
        }
        if i < min
        {
            min = i;
        }
    }
    print!("Max: {max}, min: {min}");
}
// 4
fn main()
{
    let massiv = [10, 20, 30, 40, 50];
    for i in 0..massiv.len()
    {
        print!("{}", massiv[i]);
    }
    println!();
    for k in (0..5).rev()
    {
        print!("{}", massiv[k]);
    }
}
// 5
use std::io;
fn main()
{
    let massiv = [10, 20, 30, 40, 50, 60, 70, 80];
    let mut count = 0;
    let mut even = 0;
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let bing: i32 = input.trim().parse().unwrap();
    for i in massiv
    {
        if i == bing
        {
            count += 1;
        }
        if i % 2 == 0
        {
            even += 1;
        }
        println!("The number was encountered: {count}");
        print!("Even: {even}");
    }
}
