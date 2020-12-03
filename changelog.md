# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [2.0.0](https://github.com/unity-game-framework/ugf-builder/releases/tag/2.0.0) - 2020-12-03  

### Release Notes

- [Milestone](https://github.com/unity-game-framework/ugf-builder/milestone/3?closed=1)  
    

### Changed

- Rework builders ([#17](https://github.com/unity-game-framework/ugf-builder/pull/17))  
    - Add `IBuilder`, `IBuilder<TResult>` and `IBuilder<TArguments, TResult>` interfaces used to implement basic builders.
    - Add `IBuilderAsync`, `IBuilderAsync<TResult>` and `IBuilderAsync<TArguments, TResult>` interfaces used to implement async builders.
    - Add default implementations for `IBuilder` and others to use them from classes, assets and components.
    - Add default implementations for `IBuilderAsync` and others to use them from classes and assets.
    - Remove all legacy builders.
- Update to Unity 2020.2 ([#16](https://github.com/unity-game-framework/ugf-builder/pull/16))

## [1.1.0](https://github.com/unity-game-framework/ugf-builder/releases/tag/1.1.0) - 2019-03-14  

- [Commits](https://github.com/unity-game-framework/ugf-builder/compare/1.0.0...1.1.0)
- [Milestone](https://github.com/unity-game-framework/ugf-builder/milestone/2?closed=1)

### Added
- `IGameObjectBuilder<T>` and `GameObjectBuilder<T>` to build gameobject from the source component. (#7)

## [1.1.0-preview.3](https://github.com/unity-game-framework/ugf-builder/releases/tag/1.1.0-preview.3) - 2019-03-12  

1.1.0-preview.3

## [1.1.0-preview.2](https://github.com/unity-game-framework/ugf-builder/releases/tag/1.1.0-preview.2) - 2019-03-12  

1.1.0-preview.2

## [1.1.0-preview.1](https://github.com/unity-game-framework/ugf-builder/releases/tag/1.1.0-preview.1) - 2019-03-12  

1.1.0-preview.1

## [1.1.0-preview](https://github.com/unity-game-framework/ugf-builder/releases/tag/1.1.0-preview) - 2019-03-08  

1.1.0-preview

## [1.0.0](https://github.com/unity-game-framework/ugf-builder/releases/tag/1.0.0) - 2019-03-05  

- [Commits](https://github.com/unity-game-framework/ugf-builder/compare/3cb37e5...1.0.0)
- [Milestone](https://github.com/unity-game-framework/ugf-builder/milestone/1?closed=1)

### Added
- This is a initial release.

## [0.0.1-preview](https://github.com/unity-game-framework/ugf-builder/releases/tag/0.0.1-preview) - 2019-02-24  

0.0.1-preview


