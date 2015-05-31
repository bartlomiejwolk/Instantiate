using UnityEditor;
using UnityEngine;

namespace InstantiateEx {

    [CustomEditor(typeof(Instantiate))]
    [CanEditMultipleObjects]
    public sealed class InstantiateEditor : Editor {
        #region FIELDS

        private Instantiate Script { get; set; }

        #endregion FIELDS

        #region SERIALIZED PROPERTIES

        private SerializedProperty description;
        private SerializedProperty gameObjectReference;
        private SerializedProperty instantiatePosition;

        #endregion SERIALIZED PROPERTIES

        #region UNITY MESSAGES

        public override void OnInspectorGUI() {
            serializedObject.Update();

            DrawVersionLabel();
            DrawDescriptionTextArea();

            EditorGUILayout.Space();

            DrawGameObjectReferenceField();
            DrawInstantiatePositionField();

            serializedObject.ApplyModifiedProperties();
        }
        private void OnEnable() {
            Script = (Instantiate)target;

            description = serializedObject.FindProperty("description");
            gameObjectReference =
                serializedObject.FindProperty("gameObjectReference");
            instantiatePosition =
                serializedObject.FindProperty("instantiatePosition");
        }

        #endregion UNITY MESSAGES

        #region INSPECTOR CONTROLS
        private void DrawInstantiatePositionField() {
            EditorGUILayout.PropertyField(
                instantiatePosition,
                new GUIContent(
                    "Position",
                    "Position for the instantiated game object."));
        }

        private void DrawGameObjectReferenceField() {
            EditorGUILayout.PropertyField(
                gameObjectReference,
                new GUIContent(
                    "Game Object",
                    "Game object to be instantiated."));
        }


        private void DrawVersionLabel() {
            EditorGUILayout.LabelField(
                string.Format(
                    "{0} ({1})",
                    InstantiateEx.Instantiate.Version,
                    InstantiateEx.Instantiate.Extension));
        }

        private void DrawDescriptionTextArea() {
            description.stringValue = EditorGUILayout.TextArea(
                description.stringValue);
        }

        #endregion INSPECTOR

        #region METHODS

        [MenuItem("Component/Instantiate")]
        private static void AddEntryToComponentMenu() {
            if (Selection.activeGameObject != null) {
                Selection.activeGameObject.AddComponent(typeof(Instantiate));
            }
        }

        #endregion METHODS
    }

}