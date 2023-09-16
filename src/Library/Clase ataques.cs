namespace Library
{
    public class Ataques
    {
        public static string Atacar_EnanotoEnano (Enanos enano1, Enanos enano2)
        {
            //bloque de actualizacion de armadura y ataque en caso de que se hayan usado activables en items.
            enano2.ArmaduraDinamica = 0;
            enano2.AtaqueDinamico = 0;
            enano2.ArmaduraDinamica += (enano2.Item_1.ArmaduraDinamicaItem + enano2.ArmaduraBase + enano2.Item_2.ArmaduraDinamicaItem);
            enano2.AtaqueDinamico += (enano2.Item_1.AtaqueDinamicoItem + enano2.AtaqueBase + enano2.Item_2.AtaqueDinamicoItem);
           
            //bloque de actualizacion de armadura y ataque en caso de que se hayan usado activables en items.
            enano1.ArmaduraDinamica = 0;
            enano1.AtaqueDinamico = 0;
            enano1.ArmaduraDinamica += (enano1.Item_1.ArmaduraDinamicaItem + enano1.ArmaduraBase + enano1.Item_2.ArmaduraDinamicaItem);
            enano1.AtaqueDinamico += (enano1.Item_1.AtaqueDinamicoItem + enano1.AtaqueBase + enano1.Item_2.AtaqueDinamicoItem);
            
            if (enano2.ArmaduraDinamica >= enano2.AtaqueDinamico) //checkeo si la armadura del enano acatado es mayor o igual que el ataque del enano atacante.
            {
                return $"{enano1.Nombre} no le ha sacado vida a {enano2.Nombre} por la fortaleza de su armadura";
                //si es mayor o igual imprimo en consola que el atacante no le saca vida al atacado por su armadura.
            }
            else 
            {
                //de lo contrario, cubro la vida base del enano atacado con la armadura y le resto la vida que no cubra la armadura.
                int vida_restante = (enano2.SaludBase + enano2.ArmaduraDinamica) - enano1.AtaqueDinamico;
                enano2.SaludDinamica = vida_restante; //actualizo la salud del enano atacado.
                if (vida_restante <= 0) //checkeo si la vida es 0 o menos.
                {
                    return $"{enano2.Nombre} fue asesinado por {enano1.Nombre}";
                    //si es 0 o menos imprimo el mensaje de que el atacado fue asesinado.
                }
                else 
                {   
                    //de lo contrario imprimo en consola la cantidad de vida que le quito el enano atacante calculando el resto de la armadura menos el ataque.
                    return $"{enano1.Nombre} le ha quitado {-(enano2.ArmaduraDinamica - enano1.AtaqueDinamico)} puntos de vida a {enano2.Nombre}";
                }
            }
        }

        public static string Atacar_EnanotoMago (Enanos enano, Magos mago)
        {
            //bloque de actualizacion de armadura y ataque en caso de que se hayan usado activables en items.
            mago.ArmaduraDinamica = 0;
            mago.AtaqueDinamico = 0;
            mago.ArmaduraDinamica += (mago.Item_1.ArmaduraDinamicaItem + mago.ArmaduraBase + mago.Item_2.ArmaduraDinamicaItem);
            mago.AtaqueDinamico += (mago.Item_1.AtaqueDinamicoItem + mago.AtaqueBase + mago.Item_2.AtaqueDinamicoItem);
           
            //bloque de actualizacion de armadura y ataque en caso de que se hayan usado activables en items.
            enano.ArmaduraDinamica = 0;
            enano.AtaqueDinamico = 0;
            enano.ArmaduraDinamica += (enano.Item_1.ArmaduraDinamicaItem + enano.ArmaduraBase + enano.Item_2.ArmaduraDinamicaItem);
            enano.AtaqueDinamico += (enano.Item_1.AtaqueDinamicoItem + enano.AtaqueBase + enano.Item_2.AtaqueDinamicoItem);
            
            if (mago.ArmaduraDinamica >= mago.AtaqueDinamico) //checkeo si la armadura del mago acatado es mayor o igual que el ataque del enano atacante.
            {
                return $"{enano.Nombre} no le ha sacado vida a {mago.Nombre} por la fortaleza de su armadura";
                //si es mayor o igual imprimo en consola que el atacante no le saca vida al atacado por su armadura.
            }
            else 
            {
                //de lo contrario, cubro la vida base del enano atacado con la armadura y le resto la vida que no cubra la armadura.
                int vida_restante = (mago.SaludBase + mago.ArmaduraDinamica) - enano.AtaqueDinamico;
                mago.SaludDinamica = vida_restante; //actualizo la salud del enano atacado.
                if (vida_restante <= 0) //checkeo si la vida es 0 o menos.
                {
                    return $"{mago.Nombre} fue asesinado por {enano.Nombre}";
                    //si es 0 o menos imprimo el mensaje de que el atacado fue asesinado.
                }
                else 
                {   
                    //de lo contrario imprimo en consola la cantidad de vida que le quito el enano atacante calculando el resto de la armadura menos el ataque.
                    return $"{enano.Nombre} le ha quitado {-(mago.ArmaduraDinamica - enano.AtaqueDinamico)} puntos de vida a {mago.Nombre}";
                }
            }
        }

        public static string Atacar_EnanotoElfo (Enanos enano, Elfos elfo)
        {
            //bloque de actualizacion de armadura y ataque en caso de que se hayan usado activables en items.
            elfo.ArmaduraDinamica = 0;
            elfo.AtaqueDinamico = 0;
            elfo.ArmaduraDinamica += (elfo.Item_1.ArmaduraDinamicaItem + elfo.ArmaduraBase + elfo.Item_2.ArmaduraDinamicaItem);
            elfo.AtaqueDinamico += (elfo.Item_1.AtaqueDinamicoItem + elfo.AtaqueBase + elfo.Item_2.AtaqueDinamicoItem);
           
            //bloque de actualizacion de armadura y ataque en caso de que se hayan usado activables en items.
            enano.ArmaduraDinamica = 0;
            enano.AtaqueDinamico = 0;
            enano.ArmaduraDinamica += (enano.Item_1.ArmaduraDinamicaItem + enano.ArmaduraBase + enano.Item_2.ArmaduraDinamicaItem);
            enano.AtaqueDinamico += (enano.Item_1.AtaqueDinamicoItem + enano.AtaqueBase + enano.Item_2.AtaqueDinamicoItem);
            
            if (elfo.ArmaduraDinamica >= elfo.AtaqueDinamico) //checkeo si la armadura del elfo acatado es mayor o igual que el ataque del enano atacante.
            {
                return $"{enano.Nombre} no le ha sacado vida a {elfo.Nombre} por la fortaleza de su armadura";
                //si es mayor o igual imprimo en consola que el atacante no le saca vida al atacado por su armadura.
            }
            else 
            {
                //de lo contrario, cubro la vida base del enano atacado con la armadura y le resto la vida que no cubra la armadura.
                int vida_restante = (elfo.SaludBase + elfo.ArmaduraDinamica) - enano.AtaqueDinamico;
                elfo.SaludDinamica = vida_restante; //actualizo la salud del enano atacado.
                if (vida_restante <= 0) //checkeo si la vida es 0 o menos.
                {
                    return $"{elfo.Nombre} fue asesinado por {enano.Nombre}";
                    //si es 0 o menos imprimo el mensaje de que el atacado fue asesinado.
                }
                else 
                {   
                    //de lo contrario imprimo en consola la cantidad de vida que le quito el enano atacante calculando el resto de la armadura menos el ataque.
                    return $"{enano.Nombre} le ha quitado {-(elfo.ArmaduraDinamica - enano.AtaqueDinamico)} puntos de vida a {elfo.Nombre}";
                }
            }
        }

        public static string Atacar_MagotoMago (Magos Mago_1, Magos Mago_2)
        {
            //bloque de actualizacion para calcular nuevamente el daño y armadura por se usaron activables de items.
            Mago_2.ArmaduraDinamica = 0;
            Mago_2.AtaqueDinamico = 0;
            Mago_2.ArmaduraDinamica += (Mago_2.Item_1.ArmaduraDinamicaItem + Mago_2.ArmaduraBase + Mago_2.Item_2.ArmaduraDinamicaItem);
            Mago_2.AtaqueDinamico += (Mago_2.Item_1.AtaqueDinamicoItem + Mago_2.AtaqueBase + Mago_2.Item_2.AtaqueDinamicoItem);
           
           //bloque de actualizacion para calcular nuevamente el daño y armadura por se usaron activables de items.
            Mago_1.ArmaduraDinamica = 0;
            Mago_1.AtaqueDinamico = 0;
            Mago_1.ArmaduraDinamica += (Mago_1.Item_1.ArmaduraDinamicaItem + Mago_1.ArmaduraBase + Mago_1.Item_2.ArmaduraDinamicaItem);
            Mago_1.AtaqueDinamico += (Mago_1.Item_1.AtaqueDinamicoItem + Mago_1.AtaqueBase + Mago_1.Item_2.AtaqueDinamicoItem);
            
            if (Mago_2.ArmaduraDinamica >= Mago_2.AtaqueDinamico) 
            {
                return $"{Mago_1.Nombre} no le ha sacado vida a {Mago_2.Nombre} por la fortaleza de su armadura";
                
            }
            else 
            {
                
                int vida_restante = (Mago_2.SaludBase + Mago_2.ArmaduraDinamica) - Mago_1.AtaqueDinamico;
                Mago_2.SaludDinamica = vida_restante;
                if (vida_restante <= 0) 
                {
                    return $"{Mago_2.Nombre} fue asesinado por {Mago_1.Nombre}";                   
                }
                else 
                {   
                    return $"{Mago_1.Nombre} le ha quitado {-(Mago_2.ArmaduraDinamica - Mago_1.AtaqueDinamico)} puntos de vida a {Mago_2.Nombre}";
                }
            }
        }

        public static string Atacar_MagotoEnano (Magos mago, Enanos enano)
        {
            //bloque de actualizacion para calcular nuevamente el daño y armadura por se usaron activables de items.
            enano.ArmaduraDinamica = 0;
            enano.AtaqueDinamico = 0;
            enano.ArmaduraDinamica += (enano.Item_1.ArmaduraDinamicaItem + enano.ArmaduraBase + enano.Item_2.ArmaduraDinamicaItem);
            enano.AtaqueDinamico += (enano.Item_1.AtaqueDinamicoItem + enano.AtaqueBase + enano.Item_2.AtaqueDinamicoItem);
           
           //bloque de actualizacion para calcular nuevamente el daño y armadura por se usaron activables de items.
            mago.ArmaduraDinamica = 0;
            mago.AtaqueDinamico = 0;
            mago.ArmaduraDinamica += (mago.Item_1.ArmaduraDinamicaItem + mago.ArmaduraBase + mago.Item_2.ArmaduraDinamicaItem);
            mago.AtaqueDinamico += (mago.Item_1.AtaqueDinamicoItem + mago.AtaqueBase + mago.Item_2.AtaqueDinamicoItem);
            
            if (enano.ArmaduraDinamica >= enano.AtaqueDinamico) 
            {
                return $"{mago.Nombre} no le ha sacado vida a {enano.Nombre} por la fortaleza de su armadura";
                
            }
            else 
            {
                
                int vida_restante = (enano.SaludBase + enano.ArmaduraDinamica) - mago.AtaqueDinamico;
                enano.SaludDinamica = vida_restante;
                if (vida_restante <= 0) 
                {
                    return $"{enano.Nombre} fue asesinado por {mago.Nombre}";                   
                }
                else 
                {   
                    return $"{mago.Nombre} le ha quitado {-(enano.ArmaduraDinamica - mago.AtaqueDinamico)} puntos de vida a {enano.Nombre}";
                }
            }
        }

        public static string Atacar_MagotoElfo (Magos mago, Elfos elfo)
        {
            //bloque de actualizacion para calcular nuevamente el daño y armadura por se usaron activables de items.
            elfo.ArmaduraDinamica = 0;
            elfo.AtaqueDinamico = 0;
            elfo.ArmaduraDinamica += (elfo.Item_1.ArmaduraDinamicaItem + elfo.ArmaduraBase + elfo.Item_2.ArmaduraDinamicaItem);
            elfo.AtaqueDinamico += (elfo.Item_1.AtaqueDinamicoItem + elfo.AtaqueBase + elfo.Item_2.AtaqueDinamicoItem);
           
           //bloque de actualizacion para calcular nuevamente el daño y armadura por se usaron activables de items.
            mago.ArmaduraDinamica = 0;
            mago.AtaqueDinamico = 0;
            mago.ArmaduraDinamica += (mago.Item_1.ArmaduraDinamicaItem + mago.ArmaduraBase + mago.Item_2.ArmaduraDinamicaItem);
            mago.AtaqueDinamico += (mago.Item_1.AtaqueDinamicoItem + mago.AtaqueBase + mago.Item_2.AtaqueDinamicoItem);
            
            if (elfo.ArmaduraDinamica >= elfo.AtaqueDinamico) 
            {
                return $"{mago.Nombre} no le ha sacado vida a {elfo.Nombre} por la fortaleza de su armadura";
                
            }
            else 
            {
                
                int vida_restante = (elfo.SaludBase + elfo.ArmaduraDinamica) - mago.AtaqueDinamico;
                elfo.SaludDinamica = vida_restante;
                if (vida_restante <= 0) 
                {
                    return $"{elfo.Nombre} fue asesinado por {mago.Nombre}";                   
                }
                else 
                {   
                    return $"{mago.Nombre} le ha quitado {-(elfo.ArmaduraDinamica - mago.AtaqueDinamico)} puntos de vida a {elfo.Nombre}";
                }
            }
        }

        public static string Atacar_ElfotoElfo (Elfos elfo1, Elfos elfo2)
        {
            //bloque de actualizacion de armadura y ataque en caso de que se hayan usado activables en items.
            elfo2.ArmaduraDinamica = 0;
            elfo2.AtaqueDinamico = 0;
            elfo2.ArmaduraDinamica += (elfo2.Item_1.ArmaduraDinamicaItem + elfo2.ArmaduraBase + elfo2.Item_2.ArmaduraDinamicaItem);
            elfo2.AtaqueDinamico += (elfo2.Item_1.AtaqueDinamicoItem + elfo2.AtaqueBase + elfo2.Item_2.AtaqueDinamicoItem);
           
            //bloque de actualizacion de armadura y ataque en caso de que se hayan usado activables en items.
            elfo1.ArmaduraDinamica = 0;
            elfo1.AtaqueDinamico = 0;
            elfo1.ArmaduraDinamica += (elfo1.Item_1.ArmaduraDinamicaItem + elfo1.ArmaduraBase + elfo1.Item_2.ArmaduraDinamicaItem);
            elfo1.AtaqueDinamico += (elfo1.Item_1.AtaqueDinamicoItem + elfo1.AtaqueBase + elfo1.Item_2.AtaqueDinamicoItem);
            
            if (elfo2.ArmaduraDinamica >= elfo2.AtaqueDinamico) //checkeo si la armadura del enano acatado es mayor o igual que el ataque del enano atacante.
            {
                return $"{elfo1.Nombre} no le ha sacado vida a {elfo2.Nombre} por la fortaleza de su armadura";
                //si es mayor o igual imprimo en consola que el atacante no le saca vida al atacado por su armadura.
            }
            else 
            {
                //de lo contrario, cubro la vida base del enano atacado con la armadura y le resto la vida que no cubra la armadura.
                int vida_restante = (elfo2.SaludBase + elfo2.ArmaduraDinamica) - elfo1.AtaqueDinamico;
                elfo2.SaludDinamica = vida_restante; //actualizo la salud del enano atacado.
                if (vida_restante <= 0) //checkeo si la vida es 0 o menos.
                {
                    return $"{elfo2.Nombre} fue asesinado por {elfo1.Nombre}";
                    //si es 0 o menos imprimo el mensaje de que el atacado fue asesinado.
                }
                else 
                {   
                    //de lo contrario imprimo en consola la cantidad de vida que le quito el enano atacante calculando el resto de la armadura menos el ataque.
                    return $"{elfo1.Nombre} le ha quitado {-(elfo2.ArmaduraDinamica - elfo1.AtaqueDinamico)} puntos de vida a {elfo2.Nombre}";
                }
            }
        }

        public static string Atacar_ElfotoMago (Elfos elfo, Magos mago)
        {
            //bloque de actualizacion de armadura y ataque en caso de que se hayan usado activables en items.
            mago.ArmaduraDinamica = 0;
            mago.AtaqueDinamico = 0;
            mago.ArmaduraDinamica += (mago.Item_1.ArmaduraDinamicaItem + mago.ArmaduraBase + mago.Item_2.ArmaduraDinamicaItem);
            mago.AtaqueDinamico += (mago.Item_1.AtaqueDinamicoItem + mago.AtaqueBase + mago.Item_2.AtaqueDinamicoItem);
           
            //bloque de actualizacion de armadura y ataque en caso de que se hayan usado activables en items.
            elfo.ArmaduraDinamica = 0;
            elfo.AtaqueDinamico = 0;
            elfo.ArmaduraDinamica += (elfo.Item_1.ArmaduraDinamicaItem + elfo.ArmaduraBase + elfo.Item_2.ArmaduraDinamicaItem);
            elfo.AtaqueDinamico += (elfo.Item_1.AtaqueDinamicoItem + elfo.AtaqueBase + elfo.Item_2.AtaqueDinamicoItem);
            
            if (mago.ArmaduraDinamica >= mago.AtaqueDinamico) //checkeo si la armadura del enano acatado es mayor o igual que el ataque del enano atacante.
            {
                return $"{elfo.Nombre} no le ha sacado vida a {mago.Nombre} por la fortaleza de su armadura";
                //si es mayor o igual imprimo en consola que el atacante no le saca vida al atacado por su armadura.
            }
            else 
            {
                //de lo contrario, cubro la vida base del enano atacado con la armadura y le resto la vida que no cubra la armadura.
                int vida_restante = (mago.SaludBase + mago.ArmaduraDinamica) - elfo.AtaqueDinamico;
                mago.SaludDinamica = vida_restante; //actualizo la salud del enano atacado.
                if (vida_restante <= 0) //checkeo si la vida es 0 o menos.
                {
                    return $"{mago.Nombre} fue asesinado por {elfo.Nombre}";
                    //si es 0 o menos imprimo el mensaje de que el atacado fue asesinado.
                }
                else 
                {   
                    //de lo contrario imprimo en consola la cantidad de vida que le quito el enano atacante calculando el resto de la armadura menos el ataque.
                    return $"{elfo.Nombre} le ha quitado {-(mago.ArmaduraDinamica - elfo.AtaqueDinamico)} puntos de vida a {mago.Nombre}";
                }
            }
        }

        public static string Atacar_ElfotoEnano (Elfos elfo, Enanos enano)
        {
            //bloque de actualizacion de armadura y ataque en caso de que se hayan usado activables en items.
            enano.ArmaduraDinamica = 0;
            enano.AtaqueDinamico = 0;
            enano.ArmaduraDinamica += (enano.Item_1.ArmaduraDinamicaItem + enano.ArmaduraBase + enano.Item_2.ArmaduraDinamicaItem);
            enano.AtaqueDinamico += (enano.Item_1.AtaqueDinamicoItem + enano.AtaqueBase + enano.Item_2.AtaqueDinamicoItem);
           
            //bloque de actualizacion de armadura y ataque en caso de que se hayan usado activables en items.
            elfo.ArmaduraDinamica = 0;
            elfo.AtaqueDinamico = 0;
            elfo.ArmaduraDinamica += (elfo.Item_1.ArmaduraDinamicaItem + elfo.ArmaduraBase + elfo.Item_2.ArmaduraDinamicaItem);
            elfo.AtaqueDinamico += (elfo.Item_1.AtaqueDinamicoItem + elfo.AtaqueBase + elfo.Item_2.AtaqueDinamicoItem);
            
            if (enano.ArmaduraDinamica >= enano.AtaqueDinamico) //checkeo si la armadura del enano acatado es mayor o igual que el ataque del enano atacante.
            {
                return $"{elfo.Nombre} no le ha sacado vida a {enano.Nombre} por la fortaleza de su armadura";
                //si es mayor o igual imprimo en consola que el atacante no le saca vida al atacado por su armadura.
            }
            else 
            {
                //de lo contrario, cubro la vida base del enano atacado con la armadura y le resto la vida que no cubra la armadura.
                int vida_restante = (enano.SaludBase + enano.ArmaduraDinamica) - elfo.AtaqueDinamico;
                enano.SaludDinamica = vida_restante; //actualizo la salud del enano atacado.
                if (vida_restante <= 0) //checkeo si la vida es 0 o menos.
                {
                    return $"{enano.Nombre} fue asesinado por {elfo.Nombre}";
                    //si es 0 o menos imprimo el mensaje de que el atacado fue asesinado.
                }
                else 
                {   
                    //de lo contrario imprimo en consola la cantidad de vida que le quito el enano atacante calculando el resto de la armadura menos el ataque.
                    return $"{elfo.Nombre} le ha quitado {-(enano.ArmaduraDinamica - elfo.AtaqueDinamico)} puntos de vida a {enano.Nombre}";
                }
            }
        }

    }   
}