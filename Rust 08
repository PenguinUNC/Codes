//1
use std::io::{self, Write};
fn main()
{
    let mut points = String::new();
    print!("Enter your points: ");
    std::io::stdout().flush().unwrap();
    std::io::stdin().read_line(&mut points).unwrap();
    let points: i32 = points.trim().parse().unwrap();
    if (points >= 90) {
        println!("Grade: A");
    } else if (points >= 80) {
        println!("Grade: B");
    } else if (points >= 70) {
        println!("Grade: C");
    } else if (points >= 60) {
        println!("Grade: D");
    } else {
        println!("Grade: F");
    }
}
//2
use std::io::Write;
fn main()
{
    let mut season = String::new();
    print!("Enter the month: ");
    std::io::stdout().flush().unwrap();
    std::io::stdin().read_line(&mut season).unwrap();
    let season: u32 = season.trim().parse().unwrap_or(0);
    match season
    {
        1 => println!("It's winter!"),
        2 => println!("It's winter!"),
        3 => println!("It's spring!"),
        4 => println!("It's spring!"),
        5 => println!("It's spring!"),
        6 => println!("It's summer!"),
        7 => println!("It's summer!"),
        8 => println!("It's summer!"),
        9 => println!("It's autumn!"),
        10 => println!("It's autumn!"),
        11 => println!("It's autumn!"),
        12 => println!("It's winter!"),
        _ => println!("Invalid month!"),
    }
}
//3
use std::io::Write;
fn main()
{
    let mut table = String::new();
    print!("Enter the table name: ");
    std::io::stdout().flush().unwrap();
    std::io::stdin().read_line(&mut table).unwrap();
    let table = table.trim();
    for i in 1..=10 {
        println!("{} x {} = {}", table, i, i * 10);
    }
}
//4
use std::io::Write;
fn main()
{
    let mut timer = 5;
    println!("Starting countdown...");
    while timer > 0
    {
        print!("{}...\r", timer);
        std::io::stdout().flush().unwrap();
        std::thread::sleep(std::time::Duration::from_secs(1));
        timer -= 1;
    }
}
//5
use std::io::Write;
use std::cmp::Ordering;
fn main()
{
    let secret = 40;
    let mut guess = String::new();
    loop
    {
        print!("Enter your guess: ");
        std::io::stdout().flush().unwrap();
        guess.clear();
        std::io::stdin().read_line(&mut guess).expect("Failed to read line");
        let guess: u32 = guess.trim().parse().expect("Please enter a valid number");
        match guess.cmp(&secret)
        {
            Ordering::Less => println!("Too small!"),
            Ordering::Greater => println!("Too large!"),
            Ordering::Equal => 
            {
                println!("You win!");
                break;
            }
        }
    }
}
