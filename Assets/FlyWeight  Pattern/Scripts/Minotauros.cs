using System.Collections;
using UnityEngine;

public class Minotauros : MonoBehaviour
{
    private Coroutine coroutine;

    [SerializeField] Animator animator;
    [SerializeField] AnimatorStateInfo animatorStateInfo;

    private void Awake()
    {
        animator = GetComponent<Animator>();

      //  animatorStateInfo = GetComponent<AnimatorStateInfo>();
    }

    private void Start()
    {
        coroutine = StartCoroutine(Paranoia());
        coroutine = StartCoroutine(Smash());
        coroutine = StartCoroutine(Damnation());
        coroutine = StartCoroutine(Walk());
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (coroutine != null)
            {
                StopCoroutine(coroutine);
            }

            coroutine = StartCoroutine(Paranoia());
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            if (coroutine != null)
            {
                StopCoroutine(coroutine);
            }

            coroutine = StartCoroutine(Smash());
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            if (coroutine != null)
            {
                StopCoroutine(coroutine);
            }

            coroutine = StartCoroutine(Damnation());
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            if (coroutine != null)
            {
                StopCoroutine(coroutine);
            }

            coroutine = StartCoroutine(Walk());
        }
    }

    private IEnumerator Smash()
    {
        animator.SetTrigger("Smash");

        AnimatorClipInfo[] clipInfos = animator.GetCurrentAnimatorClipInfo(0);

        yield return CoroutineCache.GetCachedwait(clipInfos[0].clip.length);

    }

    private IEnumerator Damnation()
    {
        animator.SetTrigger("Damnation");

        AnimatorClipInfo[] clipInfos = animator.GetCurrentAnimatorClipInfo(0);

        yield return CoroutineCache.GetCachedwait(clipInfos[0].clip.length);

    }

    private IEnumerator Paranoia()
    {
        animator.SetTrigger("Paranoia");

        AnimatorClipInfo[] clipInfos = animator.GetCurrentAnimatorClipInfo(0);

        yield return CoroutineCache.GetCachedwait(clipInfos[0].clip.length);

    }

    private IEnumerator Walk()
    {
        animator.SetTrigger("walk");

        AnimatorClipInfo[] clipInfos = animator.GetCurrentAnimatorClipInfo(0);

        yield return new WaitForSeconds(clipInfos[0].clip.length);

    }


}
