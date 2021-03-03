
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    public void playgame(){
        jump.hit=false;
        jump.point=0;
        SceneManager.LoadScene(1);
    }
    // Start is called before the first frame update
}
