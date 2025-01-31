using Cysharp.Threading.Tasks;
using UnityEngine;
using System;
using System.Threading;

namespace Gameplay.Utils
{
    public class RotateObject : IDisposable
    {
        private CancellationTokenSource _cts = new CancellationTokenSource();

        public async UniTask RotateToAngleTask(Transform transform, Quaternion targetRotation, float rotationTime)
        {
            Quaternion startRotation = transform.rotation;
            Quaternion endRotation = startRotation * targetRotation;
            float elapsedTime = 0f;

            try
            {
                while (elapsedTime < rotationTime)
                {
                    await UniTask.Yield(_cts.Token);

                    transform.rotation = Quaternion.Slerp(startRotation, endRotation, elapsedTime / rotationTime);
                    elapsedTime += Time.deltaTime;
                }
            }
            catch (OperationCanceledException)
            {
                Debug.Log("Rotate operation cancelled!");
            }

            transform.rotation = endRotation;
        }

        public void Dispose() => _cts.Cancel();
    }
}
