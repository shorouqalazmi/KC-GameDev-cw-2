using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw2 : MonoBehaviour
{ 
    string heroname = "robot";
    int herohigh = 165 + 5;
    int heroage = 15;
    string herosuperpower ="strong";
    string villanname = "shahad";
    int villanhigh=164;
    int villanage= 16;
    string villansuperpower = "strong evil";
    
    // Start is called before the first frame update
    void Start()
    {
        print("my heroname is" + heroname);
        print ("my heroage is" + heroage);
        print ("my herohigh is " + herohigh);
        print ("my herosuperpower is" + herosuperpower);
        print ("my villanname is"+ villanname);
        print ("my villanage is"+ villanage);
        print ("my villanhigh is"+ villanhigh);
        print ("my villansuperpower is"+ villansuperpower);
        int agediffrent = heroage - villanage;
        
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
