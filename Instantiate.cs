using UnityEngine;

namespace InstantiateEx {

    public sealed class Instantiate : MonoBehaviour {

        #region CONSTANTS

        public const string Version = "v0.1.0";
        public const string Extension = "Instantiate";

        #endregion CONSTANTS

        #region DELEGATES
        #endregion DELEGATES

        #region EVENTS
        #endregion EVENTS

        #region FIELDS

#pragma warning disable 0414
        /// <summary>
        ///     Allows identify component in the scene file when reading it with
        ///     text editor.
        /// </summary>
        [SerializeField]
        private string componentName = "Instantiate";
#pragma warning restore0414

        #endregion FIELDS

        #region INSPECTOR FIELDS

        [SerializeField]
        private string description = "Description";

        [SerializeField]
        private GameObject gameObjectReference;

        [SerializeField]
        private Transform instantiatePosition;

        #endregion INSPECTOR FIELDS

        #region PROPERTIES

        /// <summary>
        ///     Optional text to describe purpose of this instance of the component.
        /// </summary>
        public string Description {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// Reference to the game object to be instantiated.
        /// </summary>
        public GameObject GameObjectReference {
            get { return gameObjectReference; }
            set { gameObjectReference = value; }
        }

        /// <summary>
        /// 3d position of the instantiated game object will be the same
        /// as the passed transform position.
        /// </summary>
        public Transform InstantiatePosition {
            get { return instantiatePosition; }
            set { instantiatePosition = value; }
        }

        #endregion PROPERTIES

        #region UNITY MESSAGES

        private void Awake() { }

        private void FixedUpdate() { }

        private void LateUpdate() { }

        private void OnEnable() { }

        private void Reset() { }

        private void Start() { }

        private void Update() { }

        private void OnValidate() { }

        #endregion UNITY MESSAGES

        #region EVENT INVOCATORS
        #endregion INVOCATORS

        #region EVENT HANDLERS
        #endregion EVENT HANDLERS

        #region METHODS
        #endregion METHODS

    }

}