#pragma once
#include "pch.h"
#include "ClipboardSnapshot.g.h"

namespace winrt::clipboard-history-manager-windows::Core::implementation
{
    struct ClipboardSnapshot : ClipboardSnapshotT<ClipboardSnapshot>
    {
        ClipboardSnapshot() = default;

        winrt::hstring OwnerPath() const { return m_ownerPath; }
        void OwnerPath(winrt::hstring const& value) { m_ownerPath = value; }

        winrt::Windows::Storage::Streams::IBuffer OwnerIcon() const { return m_ownerIcon; }
        void OwnerIcon(winrt::Windows::Storage::Streams::IBuffer const& value) { m_ownerIcon = value; }

        winrt::Windows::Foundation::Collections::IVector<clipboard-history-manager-windows::Core::FormatRecord> Records() const { return m_records; }
        void Records(winrt::Windows::Foundation::Collections::IVector<clipboard-history-manager-windows::Core::FormatRecord> const& value) { m_records = value; }

    private:
        winrt::hstring m_ownerPath{};
        winrt::Windows::Storage::Streams::IBuffer m_ownerIcon{ nullptr };
        winrt::Windows::Foundation::Collections::IVector<clipboard-history-manager-windows::Core::FormatRecord> m_records{ nullptr };
    };
}

namespace winrt::clipboard-history-manager-windows::Core::factory_implementation
{
    struct ClipboardSnapshot : ClipboardSnapshotT<ClipboardSnapshot, implementation::ClipboardSnapshot> {};
}
