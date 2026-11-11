use std::io::{self, Write};
fn main()
{
    //1
    let mut input = String::new();
    print!("Your week: ");
    io::stdout().flush().unwrap();
    io::stdin().read_line(&mut input).unwrap();
    let num: i32 = input.trim().parse().unwrap();
    match num
    {
        1 => print!("Monday"),
        2 => print!("Tuesday"),
        3 => print!("Wednesday"),
        4 => print!("Thursday"),
        5 => print!("Friday"),
        6 => print!("Saturday"),
        7 => print!("Sunday"),
        _ => print!("E"),
    }
    println!();
    //2
    let mut input = String::new();
    print!("Your transport: ");
    io::stdout().flush().unwrap();
    io::stdin().read_line(&mut input).unwrap();
    let ch: char = input.trim().parse().expect("...");
    match ch
    {
        'c' => print!("Car"),
        'b' => print!("Bike"),
        't' => print!("Train"),
        'p' => print!("Plane"),
        _ => print!("E"),
    }
}
