﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Emotion
{
    public class Expression
    {
        public void Happy()
        {
            Console.WriteLine( "   _________    ");
            Console.WriteLine(@"  /         \    ");
            Console.WriteLine(@" /           \   ");
            Console.WriteLine( "|  |       |  |  ");
            Console.WriteLine( "|  |       |  |  ");
            Console.WriteLine( "|             |  ");
            Console.WriteLine(@" \  \_____/  /   ");
            Console.WriteLine(@"  \_________/    ");

        }
        public void Angry()
        {
            Console.WriteLine( "   _________      ");
            Console.WriteLine(@"  /         \    ");
            Console.WriteLine(@" /   \   /   \   ");
            Console.WriteLine(@"|    |   |    |  ");
            Console.WriteLine( "|             |  ");
            Console.WriteLine( "|    _____    |   ");
            Console.WriteLine(@" \  /     \  /    ");
            Console.WriteLine(@"  \_________/     ");
        }

        public void Sad()
        {
            Console.WriteLine("   _________      ");
            Console.WriteLine(@"  /         \    ");
            Console.WriteLine(@" /   /   \   \   ");
            Console.WriteLine(@"|   /|   |\   |  ");
            Console.WriteLine(@"|             |   ");
            Console.WriteLine("|    _____    |   ");
            Console.WriteLine(@" \  /     \  /    ");
            Console.WriteLine(@"  \_________/     ");

        }
        public void Sleep()
        {
            Console.WriteLine( "   _________      ");
            Console.WriteLine(@"  /         \   Z ");
            Console.WriteLine(@" /           \ Z  ");
            Console.WriteLine(@"|   --   -- Z |   ");
            Console.WriteLine(@"|         Z   |   ");
            Console.WriteLine( "|     ---     |   ");
            Console.WriteLine(@" \           /    ");
            Console.WriteLine(@"  \_________/     ");
        }
        public void Dead()
        {
            Console.WriteLine( "   _________     ");
            Console.WriteLine(@"  /         \    ");
            Console.WriteLine(@" /  \/   \/  \   ");
            Console.WriteLine(@"|   /\   /\   |  ");
            Console.WriteLine(@"|             |  ");
            Console.WriteLine(@"|      \/     |  ");
            Console.WriteLine(@" \     /\    /   ");
            Console.WriteLine(@"  \_________/    ");
        }

        public void Constipation()
        {
            Console.WriteLine(@"   _________   ");
            Console.WriteLine(@"  /         \  ");
            Console.WriteLine(@" /  /     \  \ ");
            Console.WriteLine(@"|   --   --   |");
            Console.WriteLine(@"|     _  _    |");
            Console.WriteLine(@"|      \/     |");
            Console.WriteLine(@" \    _/\_   / ");
            Console.WriteLine(@"  \_________/  ");
        }
        public void Horny()
        {
            Console.WriteLine(@"   _________          ");
            Console.WriteLine(@"  /         \     S   ");
            Console.WriteLine(@" /           \        ");
            Console.WriteLine(@"|   ()   --   |       ");
            Console.WriteLine(@"|             |   E   ");
            Console.WriteLine(@"|   )-----(   |       ");
            Console.WriteLine(@" \           /        ");
            Console.WriteLine(@"  \_________/     X   ");
        }
        public void Surprise()
        {
            Console.WriteLine(@"   _________   ");
            Console.WriteLine(@"  /         \  ");
            Console.WriteLine(@" /  /     \  \ ");
            Console.WriteLine(@"|   ()   ()   |");
            Console.WriteLine(@"|     ___     |");
            Console.WriteLine(@"|    /   \    |");
            Console.WriteLine(@" \   \___/   / ");
            Console.WriteLine(@"  \_________/  ");
        }
        public void Fear()
        {
            Console.WriteLine(@"   _________   ");
            Console.WriteLine(@"  /         \  ");
            Console.WriteLine(@" /  /     \  \ ");
            Console.WriteLine(@"|   ()   ()   |");
            Console.WriteLine(@"|   |     |   |");
            Console.WriteLine(@"|    _____    |");
            Console.WriteLine(@" \  /     \  / ");
            Console.WriteLine(@"  \_________/  ");
        }
        
        public void Dorcless()
        {
            Console.WriteLine("Ó´¬π µ´⁄ ˆ ˜´´∂ ˙´¬π. ˆ åµ ´≈†®´µ´¬¥ ®ˆç˙ å˜∂ ∫´å¨†ˆƒ¨¬.");            
        }
    }
}
