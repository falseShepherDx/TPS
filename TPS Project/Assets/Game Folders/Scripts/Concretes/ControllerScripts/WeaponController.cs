using System;
using TPSProject.Abstracts.Inputs;
using UnityEngine;
using UnityEngine.Serialization;

namespace TPSProject.Controllers
{
    public class WeaponController : MonoBehaviour
    {
         
        
        [SerializeField] private float _shootingDistance,reloadTime,timeBetweenShots,timeBetweenShooting;
        [SerializeField] private Camera _camera;
        private float _currentTime = 0f;
        [SerializeField] private LayerMask _damageableLayer;
        [SerializeField] private int _magazineSize;
        private int _bulletsLeft,bulletsShot;
        bool _isReloading,_isShooting=false,_readyToShoot;
        
        private IInputReader _input;

        private void Start()
        {
            _bulletsLeft = _magazineSize;
            _readyToShoot = true;
            _input = GetComponent<IInputReader>();
        }

        private void Update()
        {
            _currentTime += Time.deltaTime;
            // _readyToShoot = _currentTime > _fireRate;
            if (_input!=null) _isShooting = _input.AttackPressed;
          
        }

        public void Shoot()
        {
            
            // if (_isReloading || _bulletsLeft <= 0 || !_isShooting) return;
            // if (!_readyToShoot) return;
            _readyToShoot = false;
            _isShooting = true;
            if (_bulletsLeft <= 0 ||_isReloading ) return;
            Ray ray = _camera.ViewportPointToRay(Vector3.one / 2f);
            if (Physics.Raycast(ray, out RaycastHit rayhit, _shootingDistance, _damageableLayer))
            {
                Debug.Log(rayhit.collider.gameObject.name);
                
            }

            _bulletsLeft--;
            bulletsShot--;
            Invoke("ResetShot", timeBetweenShooting);

            if(bulletsShot > 0 && _bulletsLeft > 0) 
                Invoke("Shoot", timeBetweenShots);

        }

        void ResetShot()
        {
            _readyToShoot = true;
        }
         public void Reload()
        {
            if ( _bulletsLeft == _magazineSize && _isReloading) return;
            _isReloading = true;
            Invoke("ReloadFinished",reloadTime);
        }

        void ReloadFinished()
        {
            _bulletsLeft = _magazineSize;
            _isReloading = false;
            
        }
    }
    
}

