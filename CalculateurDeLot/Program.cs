using System;
using Spectre.Console;

class CalculLot {
    static void Main() {
        var rule = new Rule("[darkslategray2]Position Size Calculator[/]");
        rule.Centered();
        AnsiConsole.Write(rule);
        Console.WriteLine();
        Console.WriteLine();

        // Synchronous
        AnsiConsole.Status()
            .Start("Initialize...", ctx => 
            {
                Thread.Sleep(1000);   
                // Update the status and spinner
                ctx.Status("finished");
                ctx.Spinner(Spinner.Known.Star);
                ctx.SpinnerStyle(Style.Parse("green"));
            });

        double cap = 10000;
        double cap2 = 1400;
        double risk = 1;

        AnsiConsole.Write(new BarChart()
        .Width(60)
        .Label("[green bold underline]Accounts sizes[/]")
        .CenterLabel()
        .AddItem("Account 1", 1400, Color.Red)
        .AddItem("Account 2", 10000, Color.Green));
        Console.WriteLine();
        Console.WriteLine();


        double lot1 = LotForex(cap, risk);
        double lot2 = LotForex(cap2, risk);

        var table = new Table();
        // Add some columns
        table.AddColumn(new TableColumn("[underline]" + cap + "€ lot size:[/]").Centered());
        table.AddColumn(new TableColumn("[underline]" + cap2 + "€ lot size:[/]").Centered());
        // Add some rows
        table.AddRow("[deeppink3 bold]" + lot1 + "[/]", "[deeppink3 bold]" + lot2 + "[/]");

        table.Border(TableBorder.Rounded);
        table.Expand();
        table.Centered();
        // Render the table to the console
        AnsiConsole.Write(table); 
    }

    static double LotForex(double cap, double risk) {
        double Risk = cap * (risk/100);
        double comm = 3.5;
        
        string strSL = AnsiConsole.Ask<string>("[orange1]" + cap + "€ [/]account [violet]sl size (in pips) :[/]");
        double sl = Convert.ToDouble(strSL);

        double lot1 = (Risk/10)/sl;

        double commission = lot1*comm;
        double lot_comm = (commission*lot1)/Risk;
        double lots = lot1-lot_comm;

        return lots;
    }
}
