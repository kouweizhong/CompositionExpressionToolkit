namespace CompositionExpressionToolkit
{
    public static partial class CompositionAnimationExtensions
    {
        public static Windows.UI.Composition.KeyFrameAnimation InsertExpressionKeyFrame<T>(this Windows.UI.Composition.KeyFrameAnimation animation, float normalizedProgressKey, System.Linq.Expressions.Expression<CompositionExpressionToolkit.CompositionLambda<T>> expression, Windows.UI.Composition.CompositionEasingFunction easingFunction=null) { return default(Windows.UI.Composition.KeyFrameAnimation); }
        public static System.Collections.Generic.Dictionary<string, object> SetExpression<T>(this Windows.UI.Composition.ExpressionAnimation animation, System.Linq.Expressions.Expression<CompositionExpressionToolkit.CompositionLambda<T>> expression) { return default(System.Collections.Generic.Dictionary<string, object>); }
        public static bool SetParameter<T>(this T animation, string key, object input) where T : Windows.UI.Composition.CompositionAnimation { return default(bool); }
        public static T SetParameters<T>(this T animation, System.Collections.Generic.Dictionary<string, object> parameters) where T : Windows.UI.Composition.CompositionAnimation { return default(T); }
    }
    public partial class CompositionExpressionContext<T>
    {
        internal CompositionExpressionContext() { }
        public T FinalValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T); } }
        public T StartingValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T); } }
        public System.Numerics.Vector2 Abs(System.Numerics.Vector2 value) { return default(System.Numerics.Vector2); }
        public System.Numerics.Vector3 Abs(System.Numerics.Vector3 value) { return default(System.Numerics.Vector3); }
        public System.Numerics.Vector4 Abs(System.Numerics.Vector4 value) { return default(System.Numerics.Vector4); }
        public float Abs(float value) { return default(float); }
        public float Acos(float value) { return default(float); }
        public float Asin(float value) { return default(float); }
        public float Atan(float value) { return default(float); }
        public float Ceiling(float value) { return default(float); }
        public float Clamp(float value, float min, float max) { return default(float); }
        public Windows.UI.Color ColorLerp(Windows.UI.Color ColorTo, Windows.UI.Color ColorFrom, float Progression) { return default(Windows.UI.Color); }
        public Windows.UI.Color ColorLerpHSL(Windows.UI.Color ColorTo, Windows.UI.Color ColorFrom, float Progression) { return default(Windows.UI.Color); }
        public Windows.UI.Color ColorLerpRGB(Windows.UI.Color ColorTo, Windows.UI.Color ColorFrom, float Progression) { return default(Windows.UI.Color); }
        public System.Numerics.Quaternion Concatenate(System.Numerics.Quaternion value, System.Numerics.Quaternion value2) { return default(System.Numerics.Quaternion); }
        public float Cos(float value) { return default(float); }
        public System.Numerics.Vector2 Distance(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { return default(System.Numerics.Vector2); }
        public System.Numerics.Vector3 Distance(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { return default(System.Numerics.Vector3); }
        public System.Numerics.Vector4 Distance(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { return default(System.Numerics.Vector4); }
        public float DistanceSquared(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { return default(float); }
        public float DistanceSquared(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { return default(float); }
        public float DistanceSquared(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { return default(float); }
        public float Floor(float value) { return default(float); }
        public System.Numerics.Vector2 Inverse(System.Numerics.Vector2 value) { return default(System.Numerics.Vector2); }
        public System.Numerics.Vector3 Inverse(System.Numerics.Vector3 value) { return default(System.Numerics.Vector3); }
        public System.Numerics.Vector4 Inverse(System.Numerics.Vector4 value) { return default(System.Numerics.Vector4); }
        public System.Numerics.Vector2 Length(System.Numerics.Vector2 value) { return default(System.Numerics.Vector2); }
        public System.Numerics.Vector3 Length(System.Numerics.Vector3 value) { return default(System.Numerics.Vector3); }
        public System.Numerics.Vector4 Length(System.Numerics.Vector4 value) { return default(System.Numerics.Vector4); }
        public System.Numerics.Vector2 LengthSquared(System.Numerics.Vector2 value) { return default(System.Numerics.Vector2); }
        public System.Numerics.Vector3 LengthSquared(System.Numerics.Vector3 value) { return default(System.Numerics.Vector3); }
        public System.Numerics.Vector4 LengthSquared(System.Numerics.Vector4 value) { return default(System.Numerics.Vector4); }
        public System.Numerics.Matrix3x2 Lerp(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2, float progress) { return default(System.Numerics.Matrix3x2); }
        public System.Numerics.Matrix4x4 Lerp(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2, float progress) { return default(System.Numerics.Matrix4x4); }
        public System.Numerics.Vector2 Lerp(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2, float progress) { return default(System.Numerics.Vector2); }
        public System.Numerics.Vector3 Lerp(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2, float progress) { return default(System.Numerics.Vector3); }
        public System.Numerics.Vector4 Lerp(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2, float progress) { return default(System.Numerics.Vector4); }
        public float Ln(float value) { return default(float); }
        public float Log10(float value) { return default(float); }
        public System.Numerics.Matrix3x2 Matrix3x2(float M11, float M12, float M21, float M22, float M31, float M32) { return default(System.Numerics.Matrix3x2); }
        public System.Numerics.Matrix3x2 Matrix3x2CreateFromScale(System.Numerics.Vector2 scale) { return default(System.Numerics.Matrix3x2); }
        public System.Numerics.Matrix3x2 Matrix3x2CreateFromTranslation(System.Numerics.Vector2 translation) { return default(System.Numerics.Matrix3x2); }
        public System.Numerics.Matrix4x4 Matrix4x4(float M11, float M12, float M13, float M14, float M21, float M22, float M23, float M24, float M31, float M32, float M33, float M34, float M41, float M42, float M43, float M44) { return default(System.Numerics.Matrix4x4); }
        public System.Numerics.Matrix4x4 Matrix4x4CreateFromAxisAngle(System.Numerics.Vector3 axis, float angle) { return default(System.Numerics.Matrix4x4); }
        public System.Numerics.Matrix4x4 Matrix4x4CreateFromScale(System.Numerics.Vector3 scale) { return default(System.Numerics.Matrix4x4); }
        public System.Numerics.Matrix4x4 Matrix4x4CreateFromTranslation(System.Numerics.Vector3 translation) { return default(System.Numerics.Matrix4x4); }
        public float Max(float value1, float value2) { return default(float); }
        public float Min(float value1, float value2) { return default(float); }
        public float Mod(float dividend, float divisor) { return default(float); }
        public float Normalize() { return default(float); }
        public System.Numerics.Vector2 Normalize(System.Numerics.Vector2 value) { return default(System.Numerics.Vector2); }
        public System.Numerics.Vector3 Normalize(System.Numerics.Vector3 value) { return default(System.Numerics.Vector3); }
        public System.Numerics.Vector4 Normalize(System.Numerics.Vector4 value) { return default(System.Numerics.Vector4); }
        public float Pow(float value, int power) { return default(float); }
        public System.Numerics.Quaternion QuaternionCreateFromAxisAngle(System.Numerics.Vector3 axis, float angle) { return default(System.Numerics.Quaternion); }
        public float Round(float value) { return default(float); }
        public System.Numerics.Matrix3x2 Scale(System.Numerics.Matrix3x2 value, float factor) { return default(System.Numerics.Matrix3x2); }
        public System.Numerics.Matrix4x4 Scale(System.Numerics.Matrix4x4 value, float factor) { return default(System.Numerics.Matrix4x4); }
        public System.Numerics.Vector2 Scale(System.Numerics.Vector2 value, float factor) { return default(System.Numerics.Vector2); }
        public System.Numerics.Vector3 Scale(System.Numerics.Vector3 value, float factor) { return default(System.Numerics.Vector3); }
        public System.Numerics.Vector4 Scale(System.Numerics.Vector4 value, float factor) { return default(System.Numerics.Vector4); }
        public float Sin(float value) { return default(float); }
        public System.Numerics.Quaternion Slerp(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2, float progress) { return default(System.Numerics.Quaternion); }
        public float Sqrt(float value) { return default(float); }
        public float Square(float value) { return default(float); }
        public float Tan(float value) { return default(float); }
        public float ToDegrees(float radians) { return default(float); }
        public float ToRadians(float degrees) { return default(float); }
        public System.Numerics.Vector2 Transform(System.Numerics.Vector2 value, System.Numerics.Matrix3x2 matrix) { return default(System.Numerics.Vector2); }
        public System.Numerics.Vector4 Transform(System.Numerics.Vector4 value, System.Numerics.Matrix4x4 matrix) { return default(System.Numerics.Vector4); }
        public System.Numerics.Vector2 Vector2(float x, float y) { return default(System.Numerics.Vector2); }
        public System.Numerics.Vector3 Vector3(float x, float y, float z) { return default(System.Numerics.Vector3); }
        public System.Numerics.Vector4 Vector4(float x, float y, float z, float w) { return default(System.Numerics.Vector4); }
    }
    public abstract partial class CompositionExpressionEngine
    {
        protected CompositionExpressionEngine() { }
        public static object GetObject(System.Linq.Expressions.Expression expression) { return default(object); }
    }
    public partial class CompositionExpressionResult
    {
        public CompositionExpressionResult() { }
        public string Expression { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.Dictionary<string, object> Parameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.Dictionary<string, object>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public delegate T CompositionLambda<T>(CompositionExpressionToolkit.CompositionExpressionContext<T> ctx);
    public static partial class CompositionObjectExtensions
    {
        public static string ScaleXY(this Windows.UI.Composition.CompositionObject compositionObject) { return default(string); }
        public static void StartAnimation(this Windows.UI.Composition.CompositionObject compositionObject, System.Linq.Expressions.Expression<System.Func<object>> expression, Windows.UI.Composition.CompositionAnimation animation) { }
        public static void StopAnimation(this Windows.UI.Composition.CompositionObject compositionObject, System.Linq.Expressions.Expression<System.Func<object>> expression) { }
    }
    public static partial class CompositionPropertySetExtensions
    {
        public static T Get<T>(this Windows.UI.Composition.CompositionPropertySet propertySet, string key) { return default(T); }
        public static void Insert<T>(this Windows.UI.Composition.CompositionPropertySet propertySet, string key, object input) { }
        public static Windows.UI.Composition.CompositionPropertySet ToPropertySet(object input, Windows.UI.Composition.Compositor compositor) { return default(Windows.UI.Composition.CompositionPropertySet); }
    }
    public static partial class CompositorExtensions
    {
        public static Windows.UI.Composition.CompositionEffectFactory CreateEffectFactory(this Windows.UI.Composition.Compositor compositor, Windows.Graphics.Effects.IGraphicsEffect graphicsEffect, params System.Linq.Expressions.Expression<System.Func<object>>[] animatablePropertyExpressions) { return default(Windows.UI.Composition.CompositionEffectFactory); }
        public static Windows.UI.Composition.ExpressionAnimation CreateExpressionAnimation<T>(this Windows.UI.Composition.Compositor compositor, System.Linq.Expressions.Expression<CompositionExpressionToolkit.CompositionLambda<T>> expression) { return default(Windows.UI.Composition.ExpressionAnimation); }
        public static System.Linq.Expressions.Expression<CompositionExpressionToolkit.CompositionLambda<T>> CreateFinalValueExpression<T>(this Windows.UI.Composition.Compositor compositor) { return default(System.Linq.Expressions.Expression<CompositionExpressionToolkit.CompositionLambda<T>>); }
        public static CompositionExpressionToolkit.KeyFrameAnimation<T> CreateKeyFrameAnimation<T>(this Windows.UI.Composition.Compositor compositor) { return default(CompositionExpressionToolkit.KeyFrameAnimation<T>); }
        public static void CreateScopedBatch(this Windows.UI.Composition.Compositor compositor, Windows.UI.Composition.CompositionBatchTypes batchType, System.Action action, System.Action postAction=null) { }
        public static void CreateScopedBatch(this Windows.UI.Composition.Compositor compositor, Windows.UI.Composition.CompositionBatchTypes batchType, System.Action<Windows.UI.Composition.CompositionScopedBatch> action, System.Action<Windows.UI.Composition.CompositionScopedBatch> postAction=null) { }
        public static System.Linq.Expressions.Expression<CompositionExpressionToolkit.CompositionLambda<T>> CreateStartingValueExpression<T>(this Windows.UI.Composition.Compositor compositor) { return default(System.Linq.Expressions.Expression<CompositionExpressionToolkit.CompositionLambda<T>>); }
    }
    public static partial class DoubleExtensions
    {
        public static float Single(this double value) { return default(float); }
    }
    public sealed partial class KeyFrame<T>
    {
        public KeyFrame(float normalizedProgressKey, T value, Windows.UI.Composition.CompositionEasingFunction easing=null) { }
        public Windows.UI.Composition.CompositionEasingFunction Easing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Windows.UI.Composition.CompositionEasingFunction); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public float Key { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(float); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public T Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(T); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public sealed partial class KeyFrameAnimation<T>
    {
        public KeyFrameAnimation(Windows.UI.Composition.KeyFrameAnimation animation) { }
        public Windows.UI.Composition.KeyFrameAnimation Animation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(Windows.UI.Composition.KeyFrameAnimation); } }
        public System.TimeSpan DelayTime { get { return default(System.TimeSpan); } set { } }
        public Windows.UI.Composition.AnimationDirection Direction { get { return default(Windows.UI.Composition.AnimationDirection); } set { } }
        public System.TimeSpan Duration { get { return default(System.TimeSpan); } set { } }
        public Windows.UI.Composition.AnimationIterationBehavior IterationBehavior { get { return default(Windows.UI.Composition.AnimationIterationBehavior); } set { } }
        public int IterationCount { get { return default(int); } set { } }
        public int KeyFrameCount { get { return default(int); } }
        public Windows.UI.Composition.AnimationStopBehavior StopBehavior { get { return default(Windows.UI.Composition.AnimationStopBehavior); } set { } }
        public string Target { get { return default(string); } set { } }
        public CompositionExpressionToolkit.KeyFrameAnimation<T> DelayBy(System.TimeSpan delayTime) { return default(CompositionExpressionToolkit.KeyFrameAnimation<T>); }
        public CompositionExpressionToolkit.KeyFrameAnimation<T> ForTarget(System.Linq.Expressions.Expression<System.Func<object>> targetExpression) { return default(CompositionExpressionToolkit.KeyFrameAnimation<T>); }
        public CompositionExpressionToolkit.KeyFrameAnimation<T> HavingDuration(System.TimeSpan duration) { return default(CompositionExpressionToolkit.KeyFrameAnimation<T>); }
        public void InsertExpressionKeyFrame(float normalizedProgressKey, System.Linq.Expressions.Expression<CompositionExpressionToolkit.CompositionLambda<T>> expression, Windows.UI.Composition.CompositionEasingFunction easingFunction=null) { }
        public void InsertKeyFrame(CompositionExpressionToolkit.KeyFrame<T> keyFrame) { }
        public void InsertKeyFrame(float normalizedProgressKey, T value, Windows.UI.Composition.CompositionEasingFunction easingFunction=null) { }
        public void InsertKeyFrames(params CompositionExpressionToolkit.KeyFrame<T>[] keyFrames) { }
        public CompositionExpressionToolkit.KeyFrameAnimation<T> InTheDirection(Windows.UI.Composition.AnimationDirection direction) { return default(CompositionExpressionToolkit.KeyFrameAnimation<T>); }
        public CompositionExpressionToolkit.KeyFrameAnimation<T> OnStop(Windows.UI.Composition.AnimationStopBehavior stopBehavior) { return default(CompositionExpressionToolkit.KeyFrameAnimation<T>); }
        public CompositionExpressionToolkit.KeyFrameAnimation<T> Repeats(int count) { return default(CompositionExpressionToolkit.KeyFrameAnimation<T>); }
        public CompositionExpressionToolkit.KeyFrameAnimation<T> RepeatsForever() { return default(CompositionExpressionToolkit.KeyFrameAnimation<T>); }
    }
    public static partial class TypeExtensions
    {
        public static System.Type BaseType(this System.Type type) { return default(System.Type); }
        public static System.Type[] GetGenericArguments(this System.Type type) { return default(System.Type[]); }
        public static System.Reflection.MethodInfo GetMethod(this System.Type type, string methodName) { return default(System.Reflection.MethodInfo); }
        public static System.Reflection.PropertyInfo GetProperty(this System.Type type, string propertyName) { return default(System.Reflection.PropertyInfo); }
        public static object GetPropertyValue(this object instance, string propertyValue) { return default(object); }
        public static System.Reflection.TypeInfo GetTypeInfo(this System.Type type) { return default(System.Reflection.TypeInfo); }
        public static bool IsClass(this System.Type type) { return default(bool); }
        public static bool IsEnum(this System.Type type) { return default(bool); }
        public static bool IsGenericType(this System.Type type) { return default(bool); }
        public static bool IsPrimitive(this System.Type type) { return default(bool); }
        public static bool IsPublic(this System.Type type) { return default(bool); }
        public static bool IsSubclassOf(this System.Type type, System.Type parentType) { return default(bool); }
    }
}
