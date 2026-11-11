use std::io::{self, Write};
fn main()
{
    //1
    let mut hp = String::new();
    print!("HP: ");
    std::io::stdout().flush().unwrap();
    std::io::stdin().read_line(&mut hp).unwrap();
    let hp: i32 = hp.trim().parse().unwrap();
    if hp < 20
    {
        print!("Health of critycial!");
    }
    else if hp >= 20 && hp <= 50
    {
        print!("Health is low!");
    }
    else if hp > 50 && hp <= 100
    {
        print!("Health is good!");
    }
    else
    {
        print!("Unknown health!");
    }
    println!();
    //2
        let mut weapon = String::new();
    print!("Choise weapon: ");
    io::stdout().flush().unwrap();
    io::stdin().read_line(&mut weapon).unwrap();
    let choise: i32 = weapon.trim().parse().unwrap();
    match choise
    {
        1 => print!("Rifle, 30"),
        2 => print!("Pistol, 7"),
        3 => print!("Cold weapon, 0"),
        4 => print!("Grenade, 1"),
        5 => print!("Explosives, 1"),
        _ => print!("Unknown weapon!"),
    }
    println!();
    //3
    let mut loading_progress = 0;
    while loading_progress < 100
    {
        loading_progress += 25;
        println!("Loading... {}%", loading_progress);
    }
    //4
    let items = ["Flashlight", "Door Key"];
    let mut slot = 1;
    for item in items.iter()
    {
        println!("Slot {}: {}", slot, item);
        slot += 1;
    }
    // 5
    let mut frame = 0;
    let total = loop
    {
        frame += 1;
        println!("Frame: {}", frame);
        if frame == 5
        {
            break frame;
        }
    };
    print!("END");
}
