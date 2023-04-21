using Ejercicio2;

namespace Ejercicio02;
class Program
{
	static void Main()
	{
		/* Interfaces */
		/*PersonaInterfaces persona1 = new PersonaInterfaces(new[] { Temas.Deporte });
        PersonaInterfaces persona2 = new PersonaInterfaces(new[] { Temas.Musica });
        PersonaInterfaces persona3 = new PersonaInterfaces(new[] { Temas.Deporte, Temas.Musica });
        PeriodicoInterfaces periodico = new PeriodicoInterfaces();
        periodico.Suscribir(persona1);
        periodico.Suscribir(persona2);
        periodico.Suscribir(persona3);

        periodico.PublicarNoticias();*/


		/* EventHandler */
		/*PeriodicoEventHandler periodico = new PeriodicoEventHandler();
        PersonaEventHandler persona1 = new PersonaEventHandler(periodico, new[] { Temas.Deporte });
        PersonaEventHandler persona2 = new PersonaEventHandler(periodico, new[] { Temas.Musica });
        PersonaEventHandler persona3 = new PersonaEventHandler(periodico, new[] { Temas.Deporte, Temas.Musica });

        periodico.PublicarNoticias();*/


		PeriodicoFuncAction periodico = new PeriodicoFuncAction();
		PersonaFuncAction persona1 = new PersonaFuncAction(periodico, new[] { Temas.Deporte });
		PersonaFuncAction persona2 = new PersonaFuncAction(periodico, new[] { Temas.Musica });
		PersonaFuncAction persona3 = new PersonaFuncAction(periodico, new[] { Temas.Deporte, Temas.Musica });

		periodico.PublicarNoticias();
	}
}