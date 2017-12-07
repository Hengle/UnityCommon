﻿using System;

/// <summary>
/// Implementation is able to asynchronously load and unload <see cref="UnityResource"/> at runtime.
/// </summary>
public interface IResourceProvider
{
    /// <summary>
    /// Event executed when load progress is changed.
    /// </summary>
    event Action<float> OnLoadProgress;

    /// <summary>
    /// Whether any resource loading operations are currently active.
    /// </summary>
    bool IsLoading { get; }

    /// <summary>
    /// Current resources loading progress, in 0.0 to 1.0 range.
    /// </summary>
    float LoadProgress { get; }

    /// <summary>
    /// Loads resource asynchronously.
    /// </summary>
    /// <typeparam name="T">Type of the resource to load.</typeparam>
    /// <param name="path">Path to the resource location.</param>
    AsyncAction<UnityResource<T>> LoadResource<T> (string path) where T : UnityEngine.Object;

    /// <summary>
    /// Unloads resource asynchronously.
    /// </summary>
    /// <param name="path">Path to the resource location.</param>
    void UnloadResource (string path);
}
