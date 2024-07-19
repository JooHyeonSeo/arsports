using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class Track : MonoBehaviour
{
    public ARTrackedImageManager manager;

    public List<GameObject> list1 = new List<GameObject>();
    //public List<AudioClip> list2 = new List<AudioClip>();
    `
    private Dictionary<string, GameObject> dict1
        = new Dictionary<string, GameObject>();  
    
    //private Dictionary<string, AudioClip> dict2
    //    = new Dictionary<string, AudioClip>();

  
    void Start()
    {
        foreach(GameObject o in list1)
        {
            dict1.Add(o.name, o); 
        }

        //foreach (AudioClip o in list2)
        //{
        //  //  dict2.Add(o.name, o);
        //    Debug.Log(o.name);
        //}

    }
    void UpdateImage(ARTrackedImage t)
    {
        string name = t.referenceImage.name;

        if (dict1.TryGetValue(name, out GameObject o))
        {
            if (t.trackingState == TrackingState.Tracking)
            {
                o.transform.position = t.transform.position;
                o.transform.rotation = t.transform.rotation;
                o.SetActive(true);
                //o.GetComponent<AudioSource>().Play();
            }
            else
            {
                o.SetActive(false);
            }
        }
    }

    //void UpdateSound(ARTrackedImage t)
    //{
    //    string name = t.referenceImage.name;

    //    AudioClip sound = dict2[name];
    //    GetComponent<AudioSource>().PlayOneShot(sound);
    //}



    private void Onchanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach(ARTrackedImage t in args.added)
        {
            UpdateImage(t);
            //UpdateSound(t);
        }

        foreach (ARTrackedImage t in args.updated)
        {
            UpdateImage(t);
        }
    }
    private void OnEnable()
    {
        manager.trackedImagesChanged += Onchanged;
    }

     void OnDisable()
    {
        manager.trackedImagesChanged -= Onchanged;
    }
}

