using System.Collections;
using UnityEngine;

public class Minotauros : MonoBehaviour
{
    private Coroutine coroutine;

    [SerializeField] string[] patternName;

    [SerializeField] Animator animator;
    [SerializeField] AnimatorStateInfo animatorStateInfo;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        while(true)
        {
            yield return CoroutineCache.GetCachedwait(5.0f);

            if(coroutine != null)
            {
                StopCoroutine(coroutine);
            }

            coroutine = StartCoroutine(Pattern(patternName[Random.Range(0,patternName.Length)]));
        }
    }

    private IEnumerator Pattern(string name)
    {
        animator.SetTrigger(name);

        AnimatorClipInfo[] animatorClipInfo = animator.GetCurrentAnimatorClipInfo(0);

        yield return CoroutineCache.GetCachedwait(animatorClipInfo[0].clip.length);
    }

}
