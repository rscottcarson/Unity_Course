using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text m_text;

    private enum States { Begin, Upstairs, Downstairs, Hidden, Kitchen, Car};
    private bool hasGun;
    private States current_state;

	// Use this for initialization
	void Start () {
        hasGun = false;
        current_state = States.Begin;
	}
	
	// Update is called once per frame
	void Update () {
        print(current_state);
        switch(current_state)
        {
            case States.Begin:
                hasGun = false;
                state_begin();
                break;
            case States.Upstairs:
                state_upstairs();
                break;
            case States.Downstairs:
                state_downstairs();
                break;
            case States.Hidden:
                state_hidden();
                break;
            case States.Kitchen:
                state_kitchen();
                break;
            case States.Car:
                state_car();
                break;
            default: break;
        }
	}

    void state_begin()
    {
        m_text.text = "It is nighttime and you are sitting at the dinner table. " +
         "You hear a sound outside the back door... when you pull back the curtain you see a zombie!" +
         " What do you do next?\n\n" +
         "Press U to go Upstairs, D to go Downstairs, or H to Hide...";

        if (Input.GetKeyDown(KeyCode.U))
        {
            current_state = States.Upstairs;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            current_state = States.Downstairs;
        }
        else if(Input.GetKeyDown(KeyCode.H))
        {
            current_state = States.Hidden;
        }
    }

    void state_upstairs()
    {
        if(!hasGun)
        {
            m_text.text = "You walk upstairs and see shattered glass on the floor." +
                " You turn around and see three zombies running at you. " +
                "They eat your brains... you are dead.\n\n" +
                "Press B to begin again";

            if(Input.GetKeyDown(KeyCode.B))
            {
                current_state = States.Begin;
            }
        }
        else
        {
            m_text.text = "You walk upstairs and see shattered glass on the floor." +
                " You turn around and see three zombies running at you. " +
                "No worries... you have a gun! \n*BANG*\n*BANG*\n*BANG*\n" +
                "Now there are three dead zombies... what do you want to do?\n\n" +
                "Press K to return to the kitchen";

            if(Input.GetKeyDown(KeyCode.K))
            {
                current_state = States.Kitchen;
            }
        }
    }

    void state_downstairs()
    {
        m_text.text = "You go downstairs. You remember there is a gun in the closet.\n\n" +
            "Press G to Grab the Gun and go back to the kitchen or press K to forget the gun and run back to the Kitchen.";

        if(Input.GetKeyDown(KeyCode.G))
        {
            hasGun = true;
            current_state = States.Kitchen;
        }
        else if(Input.GetKeyDown(KeyCode.K))
        {
            current_state = States.Kitchen;
        }
        
    }

    void state_hidden()
    {
        if(!hasGun)
        {
            m_text.text = "You hide in the pantry... 'At least there's food in here', you think to yourself" +
                ". Just then you hear glass shatter. The zombies made it into the house!" +
                "It becomes quiet... then the pantry door smashes open and there are two zombies!" +
                "Turns out they're not interested in the food you have, they just want your brains!" +
                "You are dead...\n\n Press B to begin again.";

            if (Input.GetKeyDown(KeyCode.B))
            {
                current_state = States.Begin;
            }
        }
        else
        {
            m_text.text = "You hide in the pantry... 'At least there's food in here', you think to yourself" +
            ". Just then you hear glass shatter. The zombies made it into the house!" +
            "It becomes quiet... then the pantry door smashes open and there are two zombies!" +
            "\"Say hello to my little friend!\" You yell as you blast away at the zombies." +
            "\n*BANG*\n*BANG*\nThe Zombies are dead. Press K to return to the Kitchen.";

            if(Input.GetKeyDown(KeyCode.K))
            {
                current_state = States.Kitchen;
            }
        }
    }

    void state_kitchen()
    {
        m_text.text = "You're back on the main floor. There are still zombies outside." +
            "Press U to go Upstairs, D to go Downstairs, H to hide, or C to make a run for the Car.";

        if (Input.GetKeyDown(KeyCode.U))
        {
            current_state = States.Upstairs;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            current_state = States.Downstairs;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            current_state = States.Hidden;
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            current_state = States.Car;
        }
    }

    void state_car()
    {
        if(!hasGun)
        {
            m_text.text = "You decide it's time to make a run for your car. You bust out the front door, " +
                "dodge two zombies on your right, and sprint towards your car. There is a horde of zombies " +
                "between you and your car. At that moment you realize there is a gun downstairs... but it's too late." +
                "\n\nThe zombies catch you and eat your brain. \n\nPress B to start from the beginning.";

        }
        else
        {
            m_text.text = "You decide it's time to make a run for your car. You bust out the front door, " +
                "dodge two zombies on your right, and sprint towards your car. There is a horde of zombies " +
                "between you and your car. You start blasting away with your gun. Zombie parts are flying everywhere..." +
                " You get to your car safely and drive off into the night. You survived." +
                "\n\nPress B if you want to play again!";

        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            current_state = States.Begin;
        }
    }

}
